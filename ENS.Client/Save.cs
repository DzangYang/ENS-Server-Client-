using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENS.Client
{
    public class Save
    {
        public Save()
        {
        }

        public Save(string Name, string Password, string Rolle)
        {
            this.Rolle = Rolle;
            this.Name = Name;
            this.Password = Password;
           
        }

        public string Name { get; set; }
        public string Password { get; set; }

        public string Rolle { get; set; }

    }
}
