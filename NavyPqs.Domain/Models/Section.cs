using System;
using System.Linq;
using Newtonsoft.Json;

namespace NavyPqs.Domain.Models
{
    public class Section
    {
        [JsonIgnore] public string Name { get; set; }

        public string Number { get; set; }

        [JsonIgnore] public string[] LineItem { get; set; }

        public bool[] Signed { get; set; }

        public static Section UpdateSigned(Section currentSection, Section newSection)
        {
            if (!IsIdenticalSection())
            {
                var message = "Section.UpdateSigned tried to update two sections that were not the " +
                              $"same: Current: {currentSection.Number} {currentSection.Name}, New: ";
                if (newSection == null) message += "null section.";
                else message += $"{newSection.Number} {newSection.Name}.";

                throw new ArgumentException(message);
            }

            for (var i = 0; i < currentSection.Signed.Length; i++)
            {
                currentSection.Signed[i] = newSection.Signed[i];
            }
            return currentSection;

            bool IsIdenticalSection()
            {
                if (newSection == null) return false;
                if (currentSection.Name != newSection.Name) return false;
                if (currentSection.Number != newSection.Number) return false;
                if (currentSection.LineItem.Length != newSection.LineItem.Length) return false;
                if (currentSection.Signed.Length != newSection.Signed.Length) return false;
                return !currentSection.LineItem.Where((t, i) => t != newSection.LineItem[i]).Any();
            }
        }
    }
}
