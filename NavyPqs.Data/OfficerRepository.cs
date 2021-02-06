using System.Collections.Generic;
using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;

namespace NavyPqs.Data
{
    public class OfficerRepository : IOfficerRepository
    {
        public List<Officer> GetOfficers()
        {
            return new List<Officer>();
        }
    }
}
