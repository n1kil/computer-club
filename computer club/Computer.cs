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
        private int _minutesRemaining;

        public bool IsTaken
        {
            get
            {
                return _minutesRemaining > 0;
            }
            set
            {

            }
        }
        public int PricePerMinute { get; private set; }
    }
}
