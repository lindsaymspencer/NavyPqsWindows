using NavyPqs.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NavyPqs.Domain.Models
{
    public static class Pqs
    {
        internal static Dictionary<string, Type> Available => new()
        {
            {"CWO-2A", typeof(Models.Cwo.TwoAlpha)},
            {"CWO-2B", typeof(Models.Cwo.TwoBravo)}
        };

        public static string[] GetAvailable() => Available.Keys.ToArray();

        public static IPqsModel UpdatePqs(IPqsModel currentPqs, IPqsModel newPqs)
        {
            if (newPqs == null) return currentPqs;

            if (!IsIdenticalPqs())
            {
                var message = "Pqs.UpdatePqs tried to update two PQSes that were not the " +
                              $"same: Current: {currentPqs.ShortName} {currentPqs.Pqs} {currentPqs.Version}, New: " + 
                              $"{newPqs.ShortName} {newPqs.Pqs} {newPqs.Version}.";

                throw new ArgumentException(message);
            }

            for (var i = 0; i < currentPqs.Sections.Count; i++)
            {
                currentPqs.Sections[i] = Section.UpdateSigned(currentPqs.Sections[i], newPqs.Sections[i]);
            }
            return currentPqs;

            bool IsIdenticalPqs()
            {
                if (currentPqs.Pqs != newPqs.Pqs) return false;
                if (currentPqs.Version != newPqs.Version) return false;
                if (currentPqs.LongName != newPqs.LongName) return false;
                if (currentPqs.Date != newPqs.Date) return false;
                return currentPqs.Sections.Count == newPqs.Sections.Count && 
                       currentPqs.Sections.Where((t, i) => t != newPqs.Sections[i]).Any();
            }
        }
    }
}
