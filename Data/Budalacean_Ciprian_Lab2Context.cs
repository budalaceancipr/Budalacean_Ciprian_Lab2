using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Budalacean_Ciprian_Lab2.Models;

namespace Budalacean_Ciprian_Lab2.Data
{
    public class Budalacean_Ciprian_Lab2Context : DbContext
    {
        public Budalacean_Ciprian_Lab2Context (DbContextOptions<Budalacean_Ciprian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Budalacean_Ciprian_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Budalacean_Ciprian_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
