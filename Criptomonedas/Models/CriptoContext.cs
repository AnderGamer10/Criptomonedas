using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Criptomonedas.Models
{
    public class CriptoContext : DbContext
    {
        public CriptoContext(DbContextOptions<CriptoContext> options)
            : base(options)
        {
        }

        public DbSet<CriptoItems> CriptoItems { get; set; }
    }
}
