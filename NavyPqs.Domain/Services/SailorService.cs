using NavyPqs.Domain.Interfaces;
using NavyPqs.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void AddPqsTo(int aSailorId, string pqs)
        {
            var sailor = GetSailor(aSailorId);
            sailor.Pqses.Add(GetPqs());

            IPqsModel GetPqs()
            {
                // https://stackoverflow.com/questions/752/how-to-create-a-new-object-instance-from-a-type
                foreach (var instance in from option in Pqs.Available 
                    where option.Key == pqs select (IPqsModel)Activator.CreateInstance(option.Value))
                {
                    return instance;
                }
                throw new ArgumentException($"Unknown PQS: {pqs}");
            }
        }
    }
}
