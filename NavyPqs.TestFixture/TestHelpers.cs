using System;
using NavyPqs.Domain.Models;
using System.Collections.Generic;
using NavyPqs.Data;

namespace NavyPqs.TestFixture
{
    internal class TestHelpers
    {
        internal List<Sailor> Sailors = new List<Sailor>
        {
            new Sailor(0, "LT", "Jane", "Doe"),
            new Sailor(1, "CT1", "John", "Jay"),
            new Sailor(2, "ISC", "Barbra", "Miller"),
            new Sailor(3, "SA", "Robert", "Wilson")
        };

        internal bool IsSailorEqualExcludingId(Sailor x, Sailor y)
        {
            return x.Rank == y.Rank && x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        internal void InstanceSailors(SailorRepository repository, int number)
        {
            if (number > 4 || number < 1) throw new ArgumentOutOfRangeException();

            for (var i = 0; i < number; i++)
            {
                repository.CreateSailor(Sailors[i].Rank, Sailors[i].FirstName, Sailors[i].LastName);
            }
        }

    }
}
