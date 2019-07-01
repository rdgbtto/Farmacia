using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Models
{
    public class FarmaciaContext : DbContext
    {
        public FarmaciaContext (DbContextOptions<FarmaciaContext> options)
            : base(options)
        {
        }

        public DbSet<Farmacia.Models.Client> Client { get; set; }
    }
}
