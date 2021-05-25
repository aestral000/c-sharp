using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceSales.Models.EntityModels;
using WebServiceSales.Models.Services;

namespace WebServiceSales.Controllers {
    public class SalesRecordsController : Controller {

        private readonly SalesRecordService _salesRecordsService;

        public SalesRecordsController(SalesRecordService salesRecordService) {
            _salesRecordsService = salesRecordService;
        }
        
        public IActionResult Index() {

            return View();
        }

        public async Task<IActionResult> SimpleSearch(DateTime? initDate, DateTime? lastDate) {

            if (!initDate.HasValue) {

                initDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!lastDate.HasValue) {

                lastDate = DateTime.Now;
            }

            ViewData["initDate"] = initDate.Value.ToString("yyyy-MM-dd");
            ViewData["lastDate"] = lastDate.Value.ToString("yyyy-MM-dd"); 

            List<SalesRecord> salesRecords = await _salesRecordsService.FinByDateAsync(initDate, lastDate);

            return View(salesRecords);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? initDate, DateTime? lastDate) {

            if (!initDate.HasValue) {

                initDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!lastDate.HasValue) {

                lastDate = DateTime.Now;
            }

            ViewData["initDate"] = initDate.Value.ToString("yyyy-MM-dd");
            ViewData["lastDate"] = lastDate.Value.ToString("yyyy-MM-dd");

            var salesRecords = await _salesRecordsService.FinByDateGroupingAsync(initDate, lastDate);

            return View(salesRecords);
        }
    }
}
