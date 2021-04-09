﻿using System.Collections.Generic;
using NavyPqs.Domain.Interfaces;
using Newtonsoft.Json;

namespace NavyPqs.Domain.Models
{
    public class Sailor
    {
        public Sailor(int id, string rank, string firstName, string lastName)
        {
            Id = id;
            Rank = rank;
            FirstName = firstName;
            LastName = lastName;
        }

        [JsonIgnore] public int Id { get; set; }

        [JsonProperty(Order = 1)] public string Rank { get; set; }

        [JsonProperty(Order = 2)] public string FirstName { get; set; }

        [JsonProperty(Order = 3)] public string LastName { get; set; }

        [JsonProperty(Order = 4)] public List<IPqsModel> Pqses { get; set; } = new List<IPqsModel>();

        public string ToJson() => JsonConvert.SerializeObject(this);
    }
}