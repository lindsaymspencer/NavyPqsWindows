using System.Collections.Generic;
using Newtonsoft.Json;

namespace NavyPqs.Ui.Models
{
    public class PqsViewModel
    { 
        public string Pqs { get; set; }

        public string Version { get; set; }

        [JsonIgnore] public string LongName { get; set; }

        [JsonIgnore] public string Date { get; set; }

        public List<SectionViewModel> Sections { get; set; }
    }
}
