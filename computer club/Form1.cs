using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using computer_club;

namespace computer_club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddLabels();
        }

        private ComputerClub _newComputerClub = new ComputerClub(11);
        private List<Label> _labelsList = new List<Label>();
        private List<Computer> _computers;
        private Client _currentClient;
        private void AddLabels()
        {
            _labelsList.Add(label1);
            _labelsList.Add(label2);
            _labelsList.Add(label3);
            _labelsList.Add(label4);
            _labelsList.Add(label5);
            _labelsList.Add(label6);
            _labelsList.Add(label7);
            _labelsList.Add(label8);
            _labelsList.Add(label9);
            _labelsList.Add(label10);
            _labelsList.Add(label11);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void UpdateClientInfo(Client client)
        {
            labelName.Text = $"Имя - {client.Name}";
            labelMinutes.Text = $"Хочет купить {client.DesiredMinutes} минут";
        }

        private void UpdateBalanceOfClub(int money)
        {
            labelBalance.Text = $"Баланс клуба - {money}";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void UpdateComputersInfo()
        {
            for (int i = 0; i < 11; i++)
            {
                Computer computer = _newComputerClub.GetComputerById(i);
                if (computer.IsTaken)
                {
                    _labelsList[i].Text = $"Компьютер занят, осталось {computer.MinutesRemaining}";
                }
                else
                {
                    _labelsList[i].Text = $"Компьютер свободен, цена за минуту - {computer.PricePerMinute}";
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client nowClient = _newComputerClub.GetCurrentClient();
            UpdateClientInfo(_currentClient);
            _newComputerClub.SpendOneMinute();
            UpdateBalanceOfClub(_newComputerClub._money);
            UpdateComputersInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!_newComputerClub.GetComputerById(1).IsTaken)
            {
                _newComputerClub.GetComputerById(1).BecomeTaken(_currentClient); 
            }
        }
    }
}
