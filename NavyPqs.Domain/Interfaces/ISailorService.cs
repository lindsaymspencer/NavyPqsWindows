using NavyPqs.Domain.Models;
using System.Collections.Generic;

namespace NavyPqs.Domain.Interfaces
{
    public interface ISailorService
    {
        public List<Sailor> GetSailors();
        Sailor GetSailor(int id);
        bool CreateSailor(string rank, string firstName, string lastName);
        bool EditSailor(int id, Sailor sailor);
        bool DeleteSailor(int id);
    }
}
