using System.Collections.Generic;
using NavyPqsWindows.Models;

namespace NavyPqsWindows.Data
{
    public class SessionData
    {
        private int nextId = 0;

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
