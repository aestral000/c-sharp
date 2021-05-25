using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceSales.Data;
using WebServiceSales.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace WebServiceSales.Models.Services {
    public class SalesRecordService {

        private readonly WebServiceSalesContext _context;

        public SalesRecordService(WebServiceSalesContext context) {

            _context = context;
        }

        public async Task<List<SalesRecord>> FinByDateAsync(DateTime? initDate, DateTime? lastDate) {

            IQueryable<SalesRecord> salesRecords = from sales in _context.salesRecord select sales;

            if (initDate.HasValue) {

                salesRecords = salesRecords.Where(x => x.Date >= initDate.Value);
            }

            if (lastDate.HasValue) {

                salesRecords = salesRecords.Where(x => x.Date <= lastDate.Value);
            }


            return await salesRecords
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();

        }

        public async Task<List<IGrouping<Department, SalesRecord>>> FinByDateGroupingAsync(DateTime? initDate, DateTime? lastDate) {

            IQueryable<SalesRecord> salesRecords = from sales in _context.salesRecord select sales;

            if (initDate.HasValue) {

                salesRecords = salesRecords.Where(x => x.Date >= initDate.Value);
            }

            if (lastDate.HasValue) {

                salesRecords = salesRecords.Where(x => x.Date <= lastDate.Value);
            }


            return await salesRecords
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Seller.Department)
                .ToListAsync();

        }


    }
}
