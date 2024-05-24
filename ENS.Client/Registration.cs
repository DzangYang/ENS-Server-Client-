using ENS.Client.Model;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace ENS.Client
{
    public partial class Registration : Form
    {
        private readonly IAccountService accountService;
        
        private HttpClient client = new HttpClient();

        public Registration(IAccountService accountService)
        {
            InitializeComponent();
            this.accountService = accountService;
            client.BaseAddress = new Uri("https://localhost:7278/");
        }

        private async void Entbtn_ClickAsync(object sender, EventArgs e)
        {
            var test = new Test2
            {
                name = nametxt.Text,
                password = passwordtxt.Text,
                role = rolletxt.Text
            };

            try
            {
                HttpResponseMessage message = await client.PostAsJsonAsync("api/AuthControler/SignIn", test);
                if (message.IsSuccessStatusCode)
                {
                    MessageBox.Show("Successfully signed in!");
                }
                else
                {
                    MessageBox.Show($"Sign-in failed: {message.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Mainbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Test2
    {
        public string name { get; set; }
        public string password { get; set; }
        public string role { get; set; }
    }
}