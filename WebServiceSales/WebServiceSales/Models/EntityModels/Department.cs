using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceSales.Models.EntityModels {
    public class Department {

            
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }

        public Department() {
        }

        public void AddSeller(Seller seller) {

            if(seller != null) {
                Sellers.Add(seller);
            }

        }

        public double TotalSales(DateTime initial, DateTime final) {
            if(initial != null && final != null) {
               return Sellers.Sum(seller => seller.TotalSales(initial, final));
            }
            return 0;
        }

    }


}
