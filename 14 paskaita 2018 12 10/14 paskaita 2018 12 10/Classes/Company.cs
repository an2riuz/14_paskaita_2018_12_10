using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_paskaita_2018_12_10.Classes
{
    class Company
    {
        private Human _boss;
        readonly string _name;
        List<Client> clientList = new List<Client>();
        List<Worker> workerList = new List<Worker>();

        public Pet OfficePet { get; set; }

        public Company(Human boss, string companyName)
        {
            _boss = boss;
            _name = companyName;
        }

        public void AddClient(Client client)
        {
            clientList.Add(client);
        }

        public void HireWorker(Worker worker)
        {
            workerList.Add(worker);
        }

        public void FireWorker(Worker worker)
        {
            workerList.Remove(worker);
        }

        public void PrintAllClients()
        {
            foreach (Client cli in clientList)
            {
                Console.WriteLine(cli);
            }
        }

        public void PrintAllWorkers()
        {
            foreach (Worker wrk in workerList)
            {
                Console.WriteLine(wrk);
            }
        }

        public void PrintInfo()
        {
            _boss.PrintInfo();
            
        }
    }
}
