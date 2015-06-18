using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MPPV3.Models
{
    public class BelpostContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Country> Countries { get; set; }
    }


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Price { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Distance { get; set; }
    }

}