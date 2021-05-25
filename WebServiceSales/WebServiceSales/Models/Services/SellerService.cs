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

        public async Task<List<Seller>> FindAllAsync() {

            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller seller) {

            if(seller != null){
                _context.Add(seller);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<Seller> FindByIdAsync(int id) {

            return await _context.Seller.Include(seller => seller.Department).FirstOrDefaultAsync(seller => seller.Id == id);
        }

        public async Task RemoveAsync(int id) {

            try {

                Seller seller = await FindByIdAsync(id);

                _context.Seller.Remove(seller);

                await _context.SaveChangesAsync();
            }catch(DbUpdateException e) {

                throw new IntegrityException(e.Message);
            }
            
        }

        public async Task UpdateAsync(Seller seller) {

            bool hasAny = await _context.Seller.AnyAsync(s => s.Id == seller.Id);
            if (hasAny){

                try { 

                _context.Update(seller);
                await _context.SaveChangesAsync();
                }catch(DbUpdateConcurrencyException e) {

                    throw new DbConcurrencyException(e.Message);
                }
            
            }

            throw new NotFoundException("ID NOT FOUND");
        }

    }
}
