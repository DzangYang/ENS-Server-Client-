using ENS.Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENS_Server_Client_.Application.Authentification.Dto;
using System.Xml.Linq;

namespace ENS.Client
{
    public partial class Autorisation : Form
    {
        
        private readonly IAccountService accountService;
     

        private HttpClient client = new HttpClient();
       
        public Autorisation(IAccountService accountService)
        {
            InitializeComponent();
            this.accountService = accountService;
            client.BaseAddress = new Uri("https://localhost:7278/");
        }


        private async void Entbtn_Click(object sender, EventArgs e)
        {
            var test = new Test3
            {
                Name = nametxt.Text.ToString(),
                Password = passwordtxt.Text.ToString(),
            };

            try
            {
                HttpResponseMessage message = await client.PostAsJsonAsync("https://localhost:7278/api/AuthControler/LogIn", test);
                if (message.IsSuccessStatusCode)
                {
                    MessageBox.Show("Successfully signed in!");

                    var result = await message.Content.ReadFromJsonAsync<TokenResult>();
                   
                 
                    Cabinet cabinet = new Cabinet(test.Name, result.token);

                    cabinet.Show();
                    
                  
                }
                else
                {
                    var errorContent = await message.Content.ReadAsStringAsync();
                    MessageBox.Show($"Вход не удался: {message.ReasonPhrase}\n{errorContent}");
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

    public class TokenResult
    {
        public string token { get; set; }
    }
    public class Test3
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
