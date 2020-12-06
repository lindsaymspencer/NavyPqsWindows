using System.Collections.Generic;
using NavyPqsWindows.Models;

namespace NavyPqsWindows.Data
{
    public class SessionData
    {
        private List<Officer> officers = new List<Officer>();

        private int nextId = 0;

        public List<Officer> Officers => officers;

        public SessionData()
        {
            officers.Add(new Officer
            {
                Id = GetNextOfficerId(),
                FirstName = "Lindsay",
                LastName = "Spencer",
                Rank = "LTJG"
            });
            officers.Add(new Officer
            {
                Id = GetNextOfficerId(),
                LastName = "Moss",
                FirstName = "Christopher",
                Rank = "LT"
            });
            officers.Add(new Officer
            {
                Id = GetNextOfficerId(),
                LastName = "Spencer",
                FirstName = "Christopher",
                Rank = "c/SrA"
            });
            officers.Add(new Officer
            {
                Id = GetNextOfficerId(),
                LastName = "Spencer",
                FirstName = "Paul",
                Rank = "c/A1C"
            });
            officers.Add(new Officer
            {
                Id = GetNextOfficerId(),
                LastName = "Peterson",
                FirstName = "Aurora",
                Rank = "c/A1C"
            });
        }

        public void AddOfficer(Officer officer)
        {
            officer.Id = GetNextOfficerId();
            officers.Add(officer);
        }

        public void DeleteOfficer(int id)
        {
            officers.RemoveAt(id);
        }

        private int GetNextOfficerId()
        {
            return nextId++;
        }
    }
}
