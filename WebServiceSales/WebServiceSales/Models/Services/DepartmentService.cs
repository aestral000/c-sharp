using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceSales.Data;
using WebServiceSales.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace WebServiceSales.Models.Services {
    public class DepartmentService {

        private readonly WebServiceSalesContext _context;

        public DepartmentService(WebServiceSalesContext context) { 

            _context = context;
        }


        //async para dizer que iremos utilizar threads para a assinatura do método
        //Task<T> para que ele possa montar o retorno de acordo com a execução do processo
        //await para avisar o compilador que a consulta aos dados deve acontecer de forma assíncrona 
        public async Task<List<Department>> FindAllAsync() {

            return await _context.Department.OrderBy( x => x.Name).ToListAsync();
        } 

    }
}
