using NavyPqs.Domain.Models;

namespace NavyPqs.Ui.Models
{
    public class OfficerViewModel
    {
        public OfficerViewModel(Officer officer)
        {
            Rank = officer.Rank;
            FirstName = officer.FirstName;
            LastName = officer.LastName;
        }
        public string Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Rank} {FirstName} {LastName}";
    }
}
