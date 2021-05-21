using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebService.Models.EntityModels {
    public class Department {
        private int _id;
        private string _name;

        public int Id { get {return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
    }
}
