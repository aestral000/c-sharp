﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebServiceSales.Models.Services.Exception {
    public class IntegrityException : ApplicationException{

        public IntegrityException(string message) : base(message) {

        }
    }
}
