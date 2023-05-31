using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeprova01
{
    public partial class REDEFINIRSENHA : Form
    {
        public REDEFINIRSENHA()
        {
            InitializeComponent();

            label5.Click += (s, e) =>
            {
                this.Hide();
                login login = new login();
                login.ShowDialog();
            };
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
