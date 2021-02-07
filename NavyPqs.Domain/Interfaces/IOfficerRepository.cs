using System.Collections.Generic;
using NavyPqs.Domain.Models;

namespace NavyPqs.Domain.Interfaces
{
    public interface IOfficerRepository
    {
        List<Officer> GetOfficers();
        public void AddOfficer(Officer officer);
        public void DeleteOfficer(int id);
    }
}
