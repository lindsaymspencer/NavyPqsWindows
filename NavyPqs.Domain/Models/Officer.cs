using System;
using System.Collections.Generic;
using System.Text;

namespace NavyPqs.Domain.Models
{
    public class Officer
    {
        public Officer(string rank, string firstName, string lastName)
        {
            Rank = rank;
            FirstName = firstName;
            LastName = lastName;
        }
        public string Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
