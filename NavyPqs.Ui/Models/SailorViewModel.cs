using NavyPqs.Domain.Models;

namespace NavyPqs.Ui.Models
{
    public class SailorViewModel
    {
        public SailorViewModel(Sailor sailor)
        {
            Rank = sailor.Rank;
            FirstName = sailor.FirstName;
            LastName = sailor.LastName;
        }
        public string Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
