using System;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {
            Other o = new Other();

            o.setName("kekw");
            o.setNumber(12);

            Console.WriteLine(o.toString());
        }
    }

    class Other {
        private String name;
        private int number;

        public String getName() { return this.name; }

        public int getNumber() { return this.number; }

        public void setName(String name) { this.name = name; }

        public void setNumber(int number) { this.number = number; }

        public String toString() {
            return "[ Name: " + this.name + " ]\n[ Number: " + this.number + " ]";
        }
    }
}
