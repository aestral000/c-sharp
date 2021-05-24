using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebServiceSales.Models.EntityModels;

namespace WebServiceSales.Data
{
    public class WebServiceSalesContext : DbContext
    {
        public WebServiceSalesContext (DbContextOptions<WebServiceSalesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> salesRecord{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WebSales;Data Source=NOTE0050");
        }
    }
}
