using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_paskaita_2018_12_10.Classes
{
    class Worker : Human
    {
        private int _salary;
        private string _name;

        public Worker(string name, int salary) : base(name)
        {
            _salary = salary;
            _name = name;
        }

        public int GetSalary()
        {
            return _salary;
        }

        public void SetSalary()
        {
            
        }

        public void PrintInfo()
        {
            Console.WriteLine(_name + _salary);
        }
    }
}
