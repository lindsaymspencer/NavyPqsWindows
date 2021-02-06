using System;
using System.Collections.Generic;
using NavyPqs.Domain.Interfaces;

namespace NavyPqs.Domain.Models
{
    public class OfficerService : IOfficerService
    {
        private readonly IOfficerRepository repository;

        public OfficerService()
        {
            this.repository = new TempRepo();
        }
        public List<Officer> GetOfficers() => repository.GetOfficers();
    }

    public class TempRepo : IOfficerRepository
    {
        public List<Officer> GetOfficers()
        {
            return new List<Officer>
            {
                new Officer("LTJG", "Lindsay", "Spencer"),
                new Officer("LT", "Christopher", "Moss"),
                new Officer("Foo", "Paul", "Spencer")
            };
        }
    }
}
