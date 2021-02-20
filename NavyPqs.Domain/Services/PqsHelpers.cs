using NavyPqs.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace NavyPqs.Domain.Services
{
    internal class PqsHelpers
    {
        internal static void AddSections(List<Section> sections, string[] lineItems)
        {
            int sectionCounter = 0;
            for (int j = 0; j < lineItems.Count(); j++)
            {
                var values = lineItems[j].Split(';');
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
    }
}
