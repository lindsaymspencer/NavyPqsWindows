using System.Collections.Generic;
using NavyPqs.Domain.Models;

namespace NavyPqs.Domain.Interfaces
{
    public interface IOfficerService
    {
        public List<Officer> GetOfficers();
    }
}
