using Newtonsoft.Json;

namespace NavyPqs.Ui.Models
{
    public class SectionViewModel
    {
        [JsonIgnore] public string Name { get; set; }

        public string Number { get; set; }

        [JsonIgnore] public string[] LineItem { get; set; }

        public bool[] Signed { get; set; }
    }
}
