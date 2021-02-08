using System.Collections.Generic;
using NavyPqs.Domain.Models;

namespace NavyPqs.Domain.Interfaces
{
    public interface ISailorService
    {
        public List<Sailor> GetSailors();
    }
}
