using Microsoft.EntityFrameworkCore;
using ShopHW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHW.DataContext
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext(DbContextOptions options) : base(options)
        {
        }

        public MarketDbContext()
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories  { get; set; }


    }
}
