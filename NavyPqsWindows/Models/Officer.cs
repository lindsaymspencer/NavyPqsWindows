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

        [JsonIgnore]
        public CwoPqs TwoAlpha { get; set; } = CwoPqs.NewTwoAlpha();

        public string ToJson() => JsonSerializer.Serialize(this);
     
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
            toCopyTo.TwoAlpha = CwoPqs.CopyCwoPqs(toCopyTo.TwoAlpha, toCopyFrom.TwoAlpha);
            toCopyTo.TwoBravo = CwoPqs.CopyCwoPqs(toCopyTo.TwoBravo, toCopyFrom.TwoBravo);

            return toCopyTo;
        }

        public static Officer CreateFrom(string jsonString)
        {
           var x = JsonSerializer.Deserialize<Officer>(jsonString);
           var o = Officer.CopyOfficer(new Officer(), x);
           return o;
        }
    }
}
