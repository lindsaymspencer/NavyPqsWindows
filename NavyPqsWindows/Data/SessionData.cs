using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavyPqsWindows.Models;

namespace NavyPqsWindows.Data
{
    public class SessionData
    {
        private List<Officer> officers = new List<Officer>();

        private int nextId = 0;
        
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

        public List<Officer> Officers => officers;

        public void AddOfficer(string rank, string firstName, string lastName)
        {
            officers.Add(new Officer
            {
                Id = GetNextOfficerId(),
                LastName = lastName,
                FirstName = firstName,
                Rank = rank
            });
        }

        public void AddOfficer(Officer officer)
        {
            officer.Id = GetNextOfficerId();
            officers.Add(officer);
        }

        private int GetNextOfficerId()
        {
            return nextId++;
        }
    }
}
