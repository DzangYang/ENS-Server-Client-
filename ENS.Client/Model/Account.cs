using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENS.Client.Model
{
    public class Account : IAccount
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string EventTicket { get; private set; }

        public Account(string name, string password, string role)
        {
            Name = name;
            Password = password;
            Role = role;
            EventTicket = GenerateEventTicket();
        }

        private string GenerateEventTicket()
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
