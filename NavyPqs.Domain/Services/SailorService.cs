using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;
using System;
using System.Collections.Generic;

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

        public Sailor GetSailor(int id) => repository.GetSailor(id);

        public bool CreateSailor(string rank, string firstName, string lastName) =>
            repository.CreateSailor(rank, firstName, lastName);

        public bool EditSailor(int id, Sailor sailor) => repository.EditSailor(id, sailor);

        public bool DeleteSailor(int id) => repository.DeleteSailor(id);
    }
}
