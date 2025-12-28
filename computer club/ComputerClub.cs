using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using computer_club;

namespace computer_club
{
    class ComputerClub
    {
        private int _money = 0;

        private List<Computer> _computers = new List<Computer>();
        private Queue<Client> _clients = new Queue<Client>();
        

        public ComputerClub(int computersCount)
        {
            Random random = new Random();

            for(int i = 0; i < computersCount; i++)
            {
                _computers.Add(new Computer(random.Next(5, 15)));
            }

        }

        public void CreateNewClients(int count)
        {

        }
    }
}
