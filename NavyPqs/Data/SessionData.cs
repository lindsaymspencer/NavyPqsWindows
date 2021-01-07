using System.Collections.Generic;
using NavyPqs.Models;

namespace NavyPqs.Data
{
    public class SessionData
    {
        private int nextId;

        public List<Officer> Officers { get; } = new List<Officer>();

        public void AddOfficer(Officer officer)
        {
            officer.Id = GetNextOfficerId();
            Officers.Add(officer);
        }

        public void DeleteOfficer(int id)
        {
            Officers.RemoveAt(id);
        }

        private int GetNextOfficerId()
        {
            return nextId++;
        }
    }
}
