using _14_paskaita_2018_12_10.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_paskaita_2018_12_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Human boss = new Human("Vytautas");
            Company company = new Company(boss, "MyCompany");
            company.OfficePet = new Dog("Doggo");
            company.HireWorker(new Worker("Valytojas Jonas", 460));
            company.HireWorker(new Worker("Programuotojas Zilvinas", 2500));
            company.AddClient(new Client("Kestas"));
            company.AddClient(new Client("Ona"));
            company.PrintInfo();
            Console.ReadKey();
            
        }
    }
}
