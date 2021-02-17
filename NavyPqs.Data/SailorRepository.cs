using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace NavyPqs.Data
{
    public class SailorRepository : ISailorRepository
    {
        private readonly List<Sailor> sailorList;
        private int nextId;

        public SailorRepository()
        {
            sailorList = new List<Sailor>();
        }

        public bool CreateSailor(string rank, string firstName, string lastName)
        {
            try
            {
                var s = new Sailor(GetNextSailorId(), rank, firstName, lastName);
                sailorList.Add(s);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSailor(int id)
        {
            try
            {
                sailorList.RemoveAt(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditSailor(int id, Sailor sailor)
        {
            if (sailor.Id != id)
                return false;
            try
            {
                var index = sailorList.FindIndex(s => s.Id == id);
                sailorList[index] = sailor;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Sailor> GetSailors()
        {
            return sailorList;
        }

        public Sailor GetSailor(int id)
        {
            return sailorList.FirstOrDefault(s => s.Id == id);
        }

        private int GetNextSailorId()
        {
            return nextId++;
        }
    }
}