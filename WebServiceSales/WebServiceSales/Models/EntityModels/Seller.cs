using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceSales.Models.EntityModels {
    public class Seller {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public Seller() {
        }


        public void AddSales(SalesRecord sales) {
            if(sales != null) {
                Sales.Add(sales);
            }

        }

        public void RemoveSales(SalesRecord sales) {
            if(sales != null) {
                Sales.Remove(sales);
            }
        }

        public double TotalSales(DateTime initial, DateTime final) {
            if(initial != null && final != null) {
                return Sales.Where(sales => sales.Date >= initial && sales.Date <= final).Sum(sales => sales.Amount);
            }

            return 0;
        }

    }
}
