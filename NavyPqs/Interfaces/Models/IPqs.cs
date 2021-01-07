﻿using System.Collections.Generic;
using NavyPqs.Models;
using Newtonsoft.Json;

namespace NavyPqs.Interfaces.Models
{
    public interface IPqs
    {
        [JsonIgnore] string Name { get; }

        [JsonIgnore] string Date { get; }

        List<Section> Sections { get; set; }

        string ToJson();
    }
}