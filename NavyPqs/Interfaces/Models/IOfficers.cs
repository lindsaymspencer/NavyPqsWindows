using System.Collections.Generic;
using NavyPqs.Models;

namespace NavyPqs.Interfaces.Models
{
    public interface IOfficers
    {
        List<Officer> OfficerList { get; set; }

        void AddOfficer(Officer officer);

        void DeleteOfficer(int id);
    }
}