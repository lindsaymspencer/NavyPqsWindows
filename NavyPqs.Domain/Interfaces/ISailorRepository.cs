using System.Collections.Generic;
using NavyPqs.Domain.Models;

namespace NavyPqs.Domain.Interfaces
{
    public interface ISailorRepository
    {
        List<Sailor> GetSailors();
        public void AddSailor(Sailor sailor);
        public void DeleteSailor(int id);
    }
}
