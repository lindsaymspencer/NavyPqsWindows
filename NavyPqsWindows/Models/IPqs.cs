﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace NavyPqsWindows.Models
{
    public interface IPqs
    {
        [JsonIgnore] string Name { get; }

        [JsonIgnore] string Date { get; }

        List<Section> Sections { get; set; }

        string ToJson();
    }
}
