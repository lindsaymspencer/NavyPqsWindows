using NavyPqs.Domain.Models;
using System.ComponentModel;

namespace NavyPqs.Ui.Models
{
    public class SailorViewModel
    {
        public int Id { get; set; }

        public string Rank { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public static SailorViewModel CreateFrom(Sailor aSailor)
        {
            SailorViewModel result = new SailorViewModel
            {
                Id = aSailor.Id,
                Rank = aSailor.Rank,
                FirstName = aSailor.FirstName,
                LastName = aSailor.LastName,
            };

            return result;
        }
    }
}
