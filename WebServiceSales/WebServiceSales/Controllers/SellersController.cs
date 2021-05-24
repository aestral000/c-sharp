using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebServiceSales.Models;
using WebServiceSales.Models.EntityModels;
using WebServiceSales.Models.Services;
using WebServiceSales.Models.Services.Exception;
using WebServiceSales.Models.ViewModels;
using WebServiceSales.Views.Sellers;

namespace WebServiceSales.Controllers {
    public class SellersController : Controller {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerServiceservice, DepartmentService departmentService) {
            _sellerService = sellerServiceservice;
            _departmentService = departmentService;
        }
        public IActionResult Index() {

            List<Seller> list = _sellerService.FindAll();

            return View(list);
        }

        public IActionResult Create() {
            var listDepartments = _departmentService.FindAll();

            SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Departments = listDepartments };

            return View(sellerFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller) {
            if (seller != null) {
                _sellerService.Insert(seller);

            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id) {
            if (id == null) {
                return RedirectToAction(nameof(Error), new { message = "ID NOT PROVIDED" });
            }

            var seller = _sellerService.FindById(id.Value);
            if (seller == null) {
                return RedirectToAction(nameof(Error), new { message = "ID NOT FOUND" });
            }

            return View(seller);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id) {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id) {
            if (id == null) {
                return RedirectToAction(nameof(Error), new { message = "ID NOT PROVIDED" });
            }

            var seller = _sellerService.FindById(id.Value);
            if (seller == null) {
                return RedirectToAction(nameof(Error), new { message = "ID NOT FOUND" });
            }

            return View(seller);
        }

        public IActionResult Edit(int? id) {

            if (id != null) {
                Seller seller = _sellerService.FindById(id.Value);
                if (seller == null) {
                    return RedirectToAction(nameof(Error), new { message = "ID NOT PROVIDED" });
                }

                List<Department> departments = _departmentService.FindAll();
                SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(sellerFormViewModel);
            }

            return RedirectToAction(nameof(Error), new { message = "ID NOT FOUND" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller) {
            if (seller != null || id != seller.Id) {
                return RedirectToAction(nameof(Error), new { message = "ID MISMATCH" });
            }

            try {

                _sellerService.Update(seller);

                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e) {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message) {
            ErrorViewModel errorViewModel = new ErrorViewModel {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(errorViewModel);
        }
    }
}
