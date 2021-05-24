using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceSales.Data;
using WebServiceSales.Models.EntityModels;

namespace WebServiceSales.Models.Services {
    public class DepartmentService {

        private readonly WebServiceSalesContext _context;

        public DepartmentService(WebServiceSalesContext context) {
            _context = context;
        }

        public List<Department> FindAll() {

            return _context.Department.OrderBy( x => x.Name).ToList();
        } 

    }
}
