using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab09.Ex01.CodeFirst.Model;

namespace Lab09.Ex01.CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyShop")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
