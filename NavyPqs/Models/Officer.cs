using System.ComponentModel;
using System.IO;
using NavyPqs.Services;
using Newtonsoft.Json;

namespace NavyPqs.Models
{
    public class Officer
    {
        [JsonIgnore] public int Id { get; set; }

        [JsonProperty(Order = 1)] public string Rank { get; set; }

        [JsonProperty(Order = 2)] public string FirstName { get; set; }

        [JsonProperty(Order = 3)] public string LastName { get; set; }

        [JsonIgnore] public Cwo.TwoAlpha TwoAlpha = new Cwo.TwoAlpha();

        [JsonProperty("CWO.TwoBravo", Order = 4)] public Cwo.TwoBravo TwoBravo = new Cwo.TwoBravo();

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
    }
}

public class Customer : INotifyPropertyChanged
{
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (_firstName == value)
                return;
            _firstName = value;
            NotifyPropertyChanged("FirstName");
        }
    }

    private string _lastName;
    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (_lastName == value)
                return;
            _lastName = value;
            NotifyPropertyChanged("LastName");
        }
    }

    private string _company;
    public string Company
    {
        get { return _company; }
        set
        {
            if (_company == value)
                return;
            _company = value;
            NotifyPropertyChanged("Company");
        }
    }

    private string _phone;
    public string Phone
    {
        get { return _phone; }
        set
        {
            if (_phone == value)
                return;
            _phone = value;
            NotifyPropertyChanged("Phone");
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void NotifyPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
}
