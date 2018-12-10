using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_paskaita_2018_12_10.Classes
{

    class Client : Human
    {
        private int clientCount = 0;
        private string _name;
        public int ClientId
        {
            get { return clientCount; }
            set { clientCount = value; }
        }

        public Client(string name) : base (name)
        {
            _name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine(_name  + clientCount);
        }
    }
}
