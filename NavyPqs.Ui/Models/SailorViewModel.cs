using NavyPqs.Domain.Models;

namespace NavyPqs.Ui.Models
{
    public class SailorViewModel
    {
        public int Id { get; set; }
        public string Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static SailorViewModel CreateFrom(Sailor aSailor) => new()
        { Id = aSailor.Id, Rank = aSailor.Rank, FirstName = aSailor.FirstName, LastName = aSailor.LastName };
    }
}
