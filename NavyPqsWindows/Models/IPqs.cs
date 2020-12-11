using System.Collections.Generic;
using Newtonsoft.Json;

namespace NavyPqsWindows.Models
{
    interface IPqs
    {
        [JsonIgnore] string Name { get; set; }

        [JsonIgnore] string Date { get; set; }

        List<Section> Sections { get; set; }

        string ToJson();
    }
}
