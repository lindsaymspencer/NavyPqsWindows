using System;
using System.Collections.Generic;
using System.Text;
using NavyPqs.Domain.Models;

namespace NavyPqs.Domain.Interfaces
{
    public interface IOfficerRepository
    {
        List<Officer> GetOfficers();
    }
}
