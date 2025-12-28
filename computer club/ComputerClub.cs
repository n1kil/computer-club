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
        public int _money
        {
            get
            {
                return _money;
            }
            private set
            {
                _money = 0;
            }
        }

        private List<Computer> _computers = new List<Computer>();
        private Queue<Client> _clients = new Queue<Client>();
        
        

        public ComputerClub(int computersCount)
        {
            Random random = new Random();

            for(int i = 0; i < computersCount; i++)
            {
                _computers.Add(new Computer(random.Next(5, 15)));
            }


            CreateNewClients(100, random);
        }


        public Client GetCurrentClient()
        {
            return _clients.Dequeue();
        }

        public Computer GetComputerById(int index)
        {
            return _computers[index];
        }

        public void CreateNewClients(int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(0, 20);
                Client.Names name = (Client.Names)randomIndex;

                string ClientName = name.ToString();

                _clients.Enqueue(new Client(random.Next(100, 251), ClientName, random));
            }
        }

        public void Work()
        {
            while(_clients.Count > 0)
            {
                Client newClient = _clients.Dequeue();
                

                Console.WriteLine("Вы предлагаете ему компьютер: ");
                string userInput = Console.ReadLine();

                if(int.TryParse(userInput, out int computerNumber))
                {
                    computerNumber -= 1;

                    if(computerNumber >= 0 && computerNumber < _computers.Count)
                    {
                        if (_computers[computerNumber].IsTaken)
                        {
                            Console.WriteLine("Компьютер занят. Клиент разозлился и ушёл");
                        }
                        else
                        {
                            if (newClient.CheckSolvency(_computers[computerNumber]))
                            {
                                Console.WriteLine("Клиент сел за компьютер " + computerNumber + 1);
                                _money += newClient.Pay();
                                _computers[computerNumber].BecomeTaken(newClient);
                            }
                            else
                            {
                                Console.WriteLine("У клиента не хватило денег");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Клиент разозлился и ушёл");
                    }
                }
                else
                {
                    CreateNewClients(1, new Random());
                    Console.WriteLine("Неверный ввод");
                }

                Console.ReadKey();
                Console.Clear();
                SpendOneMinute();
            }
        }

        public void ShowAllComputerState()
        {
            Console.WriteLine("Список всех компьютеров");
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.WriteLine(i + 1 + " - ");
                _computers[i].ShowState();
            }
        }

        public void SpendOneMinute()
        {
            foreach(var computer in _computers)
            {
                computer.SpendOneMinute();
            }
        }

    }
}
