using System;
using System.Collections.Generic;
using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;

namespace NavyPqs.Domain.Services
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
