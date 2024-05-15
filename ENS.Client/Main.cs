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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            Registration registrtion = new Registration();
            registrtion.ShowDialog();
        }

        private void Autbnt_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();

            autorisation.Show();

            this.Close();
        }
    }
}
