using System;
using System.Collections.Generic;
using NavyPqs.Domain.Models;
using System.ComponentModel;
using Newtonsoft.Json;

namespace NavyPqs.Ui.Models
{
    public class SailorViewModel
    {
        [JsonIgnore] public int Id { get; set; }

        public string Rank { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public List<PqsViewModel> Pqses { get; set; } = new List<PqsViewModel>();

    public static SailorViewModel CreateFrom(Sailor aSailor)
        {
            SailorViewModel result = new SailorViewModel
            {
                Id = aSailor.Id,
                Rank = aSailor.Rank,
                FirstName = aSailor.FirstName,
                LastName = aSailor.LastName,
                Pqses = new List<PqsViewModel>()
            };

            foreach (var pqses in aSailor.Pqses)
            {
                PqsViewModel x = new PqsViewModel
                {
                    Pqs = pqses.Pqs, 
                    Date = pqses.Date, 
                    LongName = pqses.LongName, 
                    Version = pqses.Version,
                    Sections = new List<SectionViewModel>()
                };

                foreach (var section in pqses.Sections)
                {
                    SectionViewModel y = new SectionViewModel
                    {
                        LineItem = new string[section.LineItem.Length],
                        Name = section.Name,
                        Number = section.Number,
                        Signed = new bool[section.Signed.Length]
                    };
                    if (section.Signed.Length != section.LineItem.Length)
                    {
                        throw new Exception("lines and signatures are not equal");
                    }
                    for (int i = 0; i < section.Signed.Length; i++)
                    {
                        y.Signed[i] = section.Signed[i];
                        y.LineItem[i] = section.LineItem[i];
                    }
                    x.Sections.Add(y);
                }
                result.Pqses.Add(x);
            }

            return result;
        }
    }
}
