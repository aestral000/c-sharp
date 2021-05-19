using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enterprise.Entities.Enums;

namespace Enterprise.Entities {
    class Worker {

        private string _name;
        private WorkerLevel _level;
        private double _baseSalary;
        private Department _department;

        public string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }

        public string Level {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }

        public string BaseSalary {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }

        public Department Department {
            get {
                return this._department;
            }
            set {
                this._department = value;
            }
        }



    }
}
