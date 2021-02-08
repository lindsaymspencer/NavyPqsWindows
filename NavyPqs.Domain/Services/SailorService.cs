using System;
using System.Collections.Generic;
using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;

namespace NavyPqs.Domain.Services
{
    public class SailorService : ISailorService
    {
        private readonly ISailorRepository repository;

        public SailorService(ISailorRepository repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public List<Sailor> GetSailors() => repository.GetSailors();
    }
}
