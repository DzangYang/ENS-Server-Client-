using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENS.Client.Model
{
    public class AccountService : IAccountService
    {
        private readonly List<IAccount> accounts = new List<IAccount>();

        public AccountService()
        {
            // Создание базового аккаунта
            var adminAccount = new Account("admin", "admin", "admin");
            accounts.Add(adminAccount);
        }

        public void RegisterAccount(IAccount account)
        {
            if (AccountExists(account.Name))
            {
                throw new Exception("Account already exists.");
            }
            accounts.Add(account);
        }

        public IAccount Login(string name, string password)
        {
            var account = accounts.FirstOrDefault(a => a.Name == name && a.Password == password);
            if (account == null)
            {
                MessageBox.Show("Account not found or password incorrect.");
            }
            return account;
        }

        public bool AccountExists(string name)
        {
            return accounts.Any(a => a.Name == name);
        }
    }
}
