using System.Collections.Generic;
using System.Linq;
using NavyPqs.Interfaces.Models;
using NavyPqs.Models;

namespace NavyPqs.Services
{
    internal class PqsHelpers
    {
        internal static void AddSections(List<Section> sections, string[] a)
        {
            int sectionCounter = 0;
            for (int j = 0; j < a.Count(); j++)
            {
                var values = a[j].Split(';');
                sections.Add(new Section
                {
                    Name = values[0],
                    Number = values[1]
                });

                var signatureCount = values.Count() - 2;
                sections[sectionCounter].LineItem = new string[signatureCount];
                sections[sectionCounter].Signed = new bool[signatureCount];

                for (int i = 0; i < signatureCount; i++)
                {
                    sections[sectionCounter].LineItem[i] = values[i + 2];
                    sections[sectionCounter].Signed[i] = false;
                }

                sectionCounter++;
            }
        }

        public static IPqsModel CopyPqs(IPqsModel toCopyTo, IPqsModel toCopyFrom)
        {
            if (toCopyFrom == null)
            {
                return toCopyTo;
            }

            for (int i = 0; i < toCopyTo.Sections.Count; i++)
            {
                toCopyTo.Sections[i] = Section.CopySection(toCopyTo.Sections[i], toCopyFrom.Sections[i]);
            }

            return toCopyTo;
        }
    }
}
