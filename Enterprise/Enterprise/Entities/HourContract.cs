using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Entities {
    class HourContract {

        private DateTime _date;
        private double _valuePerHour;
        private int _hours;
        public DateTime Date {
            get {
                return this._date;
            }
            set {
                this._date = value;
            }
        }
        public double ValuePerHour {
            get {
                return this._valuePerHour;
            }
            set {
                this._valuePerHour = value;
            }
        }
        public int Hours {
            get {
                return this._hours;
            }
            set {
                this._hours = value;
            }
        }

        public HourContract() {
        }

        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() {
            return Hours * ValuePerHour;
        }
    }
}
