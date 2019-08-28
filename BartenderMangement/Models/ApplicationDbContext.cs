using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace BartenderMangement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options){ }

        public DbSet<Drink> Drink
        {
            get; set;
        }

        public DbSet<Order> Order
        {
            get; set;
        }
    }
}
