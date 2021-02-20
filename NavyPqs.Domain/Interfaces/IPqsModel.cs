using NavyPqs.Domain.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace NavyPqs.Domain.Interfaces
{
    public interface IPqsModel
    {
        string Pqs { get; }
        
        string Version { get;  }

        [JsonIgnore] string LongName { get; }

        [JsonIgnore] string Date { get; }

        List<Section> Sections { get; }
    }
}
