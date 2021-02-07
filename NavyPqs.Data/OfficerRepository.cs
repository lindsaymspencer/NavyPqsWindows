using System.Collections.Generic;
using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;

namespace NavyPqs.Data
{
    public class OfficerRepository : IOfficerRepository
    {
        private int nextId;
        private readonly List<Officer> officerList;

        public OfficerRepository()
        {
            officerList = new List<Officer>();
        }

        public List<Officer> GetOfficers()
        {
            return officerList;
        }

        public void AddOfficer(Officer officer)
        {
            officer.Id = GetNextOfficerId();
            officerList.Add(officer);
        }

        public void DeleteOfficer(int id)
        {
            officerList.RemoveAt(id);
        }

        private int GetNextOfficerId()
        {
            return nextId++;
        }
    }
}