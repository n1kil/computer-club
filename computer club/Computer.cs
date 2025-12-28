using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computer_club
{
    class Computer
    {
        private Client _client;
        public int MinutesRemaining { get; private set; }

        public bool IsTaken
        {
            get
            {
                return MinutesRemaining > 0;
            }
        }
        public int PricePerMinute { get; private set; }


        public Computer(int pricePerMinute)
        {
            PricePerMinute = pricePerMinute;
        }

        public void BecomeTaken(Client client)
        {
            _client = client;
            MinutesRemaining = _client.DesiredMinutes;
        }

        public void BecomeEmpty()
        {
            _client = null;
        }

        public void SpendOneMinute()
        {
            MinutesRemaining--;
        }

        public void ShowState()
        {
            if (IsTaken)
            {
                Console.WriteLine($"Компьютер занят, осталось {MinutesRemaining} минут");
            }
            else
            {
                Console.WriteLine($"Компьютер свободен, цена за минуту - {PricePerMinute}");
            }
        }
    }
}
