using System;
using System.Collections.Generic;
using NavyPqs.Domain.Interfaces;

namespace NavyPqs.Domain.Models
{
    public class OfficerService : IOfficerService
    {
        private readonly IOfficerRepository repository;

        public OfficerService(IOfficerRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public List<Officer> GetOfficers() => repository.GetOfficers();
    }
}
