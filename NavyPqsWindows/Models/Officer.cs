using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using NavyPqsWindows.Services;

namespace NavyPqsWindows.Models
{
    public class Officer
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string Rank { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public CwoPqs TwoBravo { get; set; } = CwoPqs.NewTwoBravo();
      
        public string ToJson() => JsonSerializer.Serialize(this);
     
        public bool Export(string path)
        {
            FileHelper.WriteOver(Path.Combine(path, LastName + FirstName + ".cw2bpqs"),
                ToJson());
            return true;
        }
    }
}
