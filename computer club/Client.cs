using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_club
{
    class Client
    {
        private int _money;
        public string Name;
        public int DesiredMinutes { get; private set; }

        public Client(int money, string name, Random random)
        {
            _money = money;
            Name = name;
            DesiredMinutes = random.Next(10, 30);
        }
    }
}
