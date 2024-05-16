using ENS.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENS.Client
{
    public partial class Autorisation : Form
    {

        private readonly IAccountService accountService;

        public Autorisation(IAccountService accountService)
        {
            InitializeComponent();
            this.accountService = accountService;
        }

        private void Entbtn_Click(object sender, EventArgs e)
        {
            var name = nametxt.Text;
            var password = passwordtxt.Text;

            var account = accountService.Login(name, password);
            if (account != null)
            {
                Cabinet cabinet = new Cabinet(account);

                cabinet.Show();
                this.Close();
                //MessageBox.Show($"Welcome, {account.Name}. Your role is {account.Role} and your event ticket is {account.EventTicket}.");
                // Далее можно выполнить действия после успешной авторизации
            }
        }

        private void Mainbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
