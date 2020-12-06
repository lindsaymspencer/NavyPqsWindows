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

        public void CreateOfficerFrom(string json)
        {
            var newOfficer = Officer.CreateFrom(json);
            newOfficer.Id = GetNextOfficerId();
            Officers.Add(newOfficer);
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
