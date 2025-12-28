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
        private int _moneyToPay;
        public string Name;
        public int DesiredMinutes { get; private set; }

        public Client(int money, string name, Random random)
        {
            _money = money;
            Name = name;
            DesiredMinutes = random.Next(10, 30);
        }

        public bool CheckSolvency(Computer computer)
        {
            _moneyToPay = DesiredMinutes * computer.PricePerMinute;
            if(_money >= _moneyToPay)
            {
                return true;
            }
            else
            {
                _moneyToPay = 0;
                return false;
            }
        }

        public int Pay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }

        public enum Names
        { 
            Oliver,
            Emma,
            Liam,
            Ava,
            Noah,
            Sophia,
            Ethan,
            Isabella,
            Lucas,
            Mia,
            Mason,
            Amelia,
            Logan,
            Charlotte,
            Jacob,
            Harper,
            Elijah,
            Evelyn,
            Alexander,
            Abigail
        }
    }
}
