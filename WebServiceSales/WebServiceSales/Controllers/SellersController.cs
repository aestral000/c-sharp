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
        public async Task<IActionResult> Index() {

            List<Seller> sellers = await _sellerService.FindAllAsync();

            return View(sellers);
        }

        public async Task<IActionResult> Create() {

            List<Department> departments = await _departmentService.FindAllAsync();

            SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Departments = departments };

            return View(sellerFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller) {

            if (!ModelState.IsValid) {

                List<Department> departments = await _departmentService.FindAllAsync();
                SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(sellerFormViewModel);
            }

            if (seller != null) {

                await _sellerService.InsertAsync(seller);

            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id) {

            if (id == null) {

                return RedirectToAction(nameof(Error), new { message = "ID NOT PROVIDED" });
            }

            Seller seller = await _sellerService.FindByIdAsync(id.Value);
            if (seller == null) {

                return RedirectToAction(nameof(Error), new { message = "ID NOT FOUND" });
            }

            return View(seller);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id) {

            try {

                await _sellerService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }catch(IntegrityException e) {

                return RedirectToAction(nameof(Error), new { message = e.Message });
            }

        }

        public async Task<IActionResult> Details(int? id) {

            if (id == null) {

                return RedirectToAction(nameof(Error), new { message = "ID NOT PROVIDED" });
            }

            Seller seller = await _sellerService.FindByIdAsync(id.Value);

            if (seller == null) {

                return RedirectToAction(nameof(Error), new { message = "ID NOT FOUND" });
            }

            return View(seller);
        }

        public async Task<IActionResult> Edit(int? id) {

            if (id != null) {

                Seller seller = await _sellerService.FindByIdAsync(id.Value);
                if (seller == null) {

                    return RedirectToAction(nameof(Error), new { message = "ID NOT PROVIDED" });
                }

                List<Department> departments = await _departmentService.FindAllAsync();
                SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(sellerFormViewModel);
            }

            return RedirectToAction(nameof(Error), new { message = "ID NOT FOUND" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Seller seller) {

            if (!ModelState.IsValid) {

                List<Department> departments = await _departmentService.FindAllAsync();
                SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(sellerFormViewModel);
            }

            if (seller != null || id != seller.Id) {

                return RedirectToAction(nameof(Error), new { message = "ID MISMATCH" });
            }

            try {

                await _sellerService.UpdateAsync(seller);
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
