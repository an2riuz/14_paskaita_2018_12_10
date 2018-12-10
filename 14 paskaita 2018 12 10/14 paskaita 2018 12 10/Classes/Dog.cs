using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_paskaita_2018_12_10.Classes
{
    class Dog : Pet
    {
        private string _name;
        public Dog(string name)
        {
            _name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine(_name);
        }
    }
}
