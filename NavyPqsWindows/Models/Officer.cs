using System.IO;
using NavyPqsWindows.Models;
using NavyPqsWindows.Services;
using Newtonsoft.Json;

namespace NavyPqsWindows.Models
{
    public class Officer
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonProperty(Order = 1)]
        public string Rank { get; set; }

        [JsonProperty(Order = 2)]
        public string FirstName { get; set; }

        [JsonProperty(Order = 3)]
        public string LastName { get; set; }

        [JsonIgnore]
        public Cwo.TwoAlpha TwoAlpha = new Cwo.TwoAlpha();

        [JsonProperty("CWO.TwoBravo", Order = 4)]
        public Cwo.TwoBravo TwoBravo = new Cwo.TwoBravo();

        public string ToJson() => JsonConvert.SerializeObject(this);
     
        public bool Export(string path)
        {
            FileHelper.WriteOver(Path.Combine(path, LastName + FirstName + ".cw2bpqs"),
                ToJson());
            return true;
        }

        public static Officer CopyOfficer(Officer toCopyTo, Officer toCopyFrom)
        {
            toCopyTo.Id = toCopyFrom.Id;
            toCopyTo.FirstName = toCopyFrom.FirstName ?? toCopyTo.FirstName;
            toCopyTo.LastName = toCopyFrom.LastName ?? toCopyTo.LastName;
            toCopyTo.Rank = toCopyFrom.Rank ?? toCopyTo.Rank;
            return toCopyTo;
        }

        public static Officer CreateFrom(string jsonString)
        {
            // TODO: Fix this.
           //var x = JsonSerializer.Deserialize<Officer>(jsonString);
           //var o = Officer.CopyOfficer(new Officer(), x);
           //return o;
           return new Officer();
        }
    }
}
