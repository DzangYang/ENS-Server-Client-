using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENS.Client.Model
{
    public interface IAccountService
    {
        void RegisterAccount(IAccount account);
        IAccount Login(string name, string password);
        bool AccountExists(string name);
    }
}
