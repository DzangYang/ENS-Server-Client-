using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ENS.Client.Model;

namespace ENS.Client
{
    public partial class Registration : Form
    {

        private readonly IAccountService accountService;

        public Registration(IAccountService accountService)
        {
            InitializeComponent();
            this.accountService = accountService;
        }




        private void Entbtn_Click(object sender, EventArgs e)
        {
            var name = nametxt.Text;
            var password = passwordtxt.Text;
            var role = rolletxt.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var account = new Account(name, password, role);
            try
            {
                accountService.RegisterAccount(account);
                MessageBox.Show("Registration successful.");
                this.Close(); // Закрыть форму после успешной регистрации
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Mainbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
