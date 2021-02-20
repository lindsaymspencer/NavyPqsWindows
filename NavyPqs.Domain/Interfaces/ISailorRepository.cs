using NavyPqs.Domain.Models;
using System.Collections.Generic;

namespace NavyPqs.Domain.Interfaces
{
    public interface ISailorRepository
    {
        List<Sailor> GetSailors();
        Sailor GetSailor(int id);
        public bool DeleteSailor(int id);
        public bool CreateSailor(string rank, string firstName, string lastName);
        public bool EditSailor(int id, Sailor sailor);
    }
}
