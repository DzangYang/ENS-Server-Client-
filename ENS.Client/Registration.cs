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
    public partial class Registration : Form
    {
        private Save save = new Save();

        public Registration()
        {
            InitializeComponent();
        }

        private void Entbtn_Click(object sender, EventArgs e)
        {

            save.Name = nametxt.Text;
            save.Password = passwordtxt.Text;
            save.Rolle = rolletxt.Text;

            this.Close();

        }
    }
}
