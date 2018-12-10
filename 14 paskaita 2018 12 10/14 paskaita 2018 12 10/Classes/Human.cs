using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_paskaita_2018_12_10.Classes
{
    class Human : LiveObject
    {
        protected string _name;
        
        public Human(string name)
        {
            _name = name;
        }
        public void PrintInfo()
        {
            Console.WriteLine("BOSS: " + _name);
        }
    }
}
