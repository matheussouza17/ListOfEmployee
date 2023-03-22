using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListaCsharp {
    internal class Employee {
        public int _id;
        private string _name;
        private decimal _salary;

        public Employee(int id, string name, decimal salary) {
            _id = id;
            _name = name;
            _salary = salary;
        }
        public void increaseSalary(decimal valor) {
            _salary += valor;
        }
        public override string ToString() {
            return _id
                + ", "
                + _name
                + ", "
                + _salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
