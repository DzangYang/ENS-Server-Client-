using System;
using System.Net;
using System.Windows.Forms;
using ENS.Client.Model;

namespace ENS.Client
{
    public partial class Cabinet : Form
    {
        private readonly IAccount account;
        public string Name { get; set; }
        public string Token { get; set; }

        public Cabinet(string name, string token)
        {
            Name = name;
            Token = token;
            InitializeComponent();

            LoadAccountData();
        }

        private void LoadAccountData()
        {
            label2.Text = $"Name: {Name}";

            TicketBox.Text = Token;

        }

        private void Evbtn_Click(object sender, EventArgs e)
        {


            var eventForm = new Event(TicketBox.Text);
            eventForm.ShowDialog();

        }
    }
}