using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceSales.Data;
using WebServiceSales.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using WebServiceSales.Models.Services.Exception;

namespace WebServiceSales.Views.Sellers {
    public class SellerService {

        private readonly WebServiceSalesContext _context;

        public SellerService(WebServiceSalesContext context) {
            _context = context;
        }

        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller) {
            if(seller != null){
                _context.Add(seller);

                _context.SaveChanges();
            }
        }

        public Seller FindById(int id) {

            return _context.Seller.Include(seller => seller.Department).FirstOrDefault(seller => seller.Id == id);
        }

        public void Remove(int id) {
            Seller seller = FindById(id);

            _context.Seller.Remove(seller);

            _context.SaveChanges();
        }

        public void Update(Seller seller) { 
            if(_context.Seller.Any(s => s.Id == seller.Id)){
                try { 
                _context.Update(seller);
                _context.SaveChanges();
                }catch(DbUpdateConcurrencyException e) {
                    throw new DbConcurrencyException(e.Message);
                }
                finally {

                }
            }

            throw new NotFoundException("ID NOT FOUND");
        }

    }
}
