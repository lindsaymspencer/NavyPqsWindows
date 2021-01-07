using System.Collections.Generic;
using NavyPqs.Interfaces.Models;

namespace NavyPqs.Models
{
    public class Officers : IOfficers
    {
        private int nextId;

        public List<Officer> OfficerList { get; set; } = new List<Officer>();

        public void AddOfficer(Officer officer)
        {
            officer.Id = GetNextOfficerId();
            OfficerList.Add(officer);
        }

        public void DeleteOfficer(int id)
        {
            OfficerList.RemoveAt(id);
        }

        private int GetNextOfficerId()
        {
            return nextId++;
        }

    }
}
