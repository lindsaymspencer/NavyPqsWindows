using System;
using System.Collections.Generic;
using System.Linq;

namespace NavyPqs.Domain.Models
{
    public static class Pqs
    {
        internal static Dictionary<string, Type> Available => new Dictionary<string, Type>
        {
            {"CWO-2A", typeof(Models.Cwo.TwoAlpha)},
            {"CWO-2B", typeof(Models.Cwo.TwoBravo)}
        };

        public static string[] GetAvailable() => Available.Keys.ToArray();
    }
}
