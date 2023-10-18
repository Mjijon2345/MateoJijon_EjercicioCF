using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MateoJijon_EjercicioCF.Models;

namespace MateoJijon_EjercicioCF.Data
{
    public class MateoJijon_EjercicioCFContext : DbContext
    {
        public MateoJijon_EjercicioCFContext (DbContextOptions<MateoJijon_EjercicioCFContext> options)
            : base(options)
        {
        }

        public DbSet<MateoJijon_EjercicioCF.Models.Burger> Burger { get; set; } = default!;
        public DbSet<MateoJijon_EjercicioCF.Models.Promo> Promo { get; set; } 
    }
}
