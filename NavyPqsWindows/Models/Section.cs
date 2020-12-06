using System.Text.Json.Serialization;

namespace NavyPqsWindows.Models
{
    public class Section
    {
        [JsonIgnore]
        public string Name { get; set; }

        public string Number { get; set; }

        [JsonIgnore]
        public string[] LineItem { get; set; }

        public bool[] Signed { get; set; }

    }
}
