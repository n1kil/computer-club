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
        }

        private ComputerClub _newComputerClub = new ComputerClub(11);

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

        private void UpdateComputerInfo(int ComputerIndex)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _newComputerClub.SpendOneMinute();
        }
    }
}
