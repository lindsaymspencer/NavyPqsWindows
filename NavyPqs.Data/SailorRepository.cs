using System.Collections.Generic;
using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;

namespace NavyPqs.Data
{
    public class SailorRepository : ISailorRepository
    {
        private int nextId;
        private readonly List<Sailor> sailorList;

        public SailorRepository()
        {
            sailorList = new List<Sailor>();
        }

        public List<Sailor> GetSailors()
        {
            return sailorList;
        }

        public void AddSailor(Sailor sailor)
        {
            sailor.Id = GetNextSailorId();
            sailorList.Add(sailor);
        }

        public void DeleteSailor(int id)
        {
            sailorList.RemoveAt(id);
        }

        private int GetNextSailorId()
        {
            return nextId++;
        }
    }
}