using System;
using System.Windows.Forms;
using ENS.Client.Model;

namespace ENS.Client
{
    public partial class Cabinet : Form
    {
        private readonly IAccount account;

        public Cabinet(IAccount account)
        {
            InitializeComponent();
            this.account = account;
            LoadAccountData();
        }

        private void LoadAccountData()
        {
            label2.Text = $"Name: {account.Name}";
            label3.Text = $"Role: {account.Role}";
            TicketBox.Text = account.EventTicket;
        }

        private void Evbtn_Click(object sender, EventArgs e)
        {
            var eventForm = new Event(account.EventTicket);
            eventForm.ShowDialog();

        }
    }
}
