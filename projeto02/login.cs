﻿using System;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrar cadastrar = new cadastrar();
            cadastrar.ShowDialog();
        }

        private void esqueceu_Click(object sender, EventArgs e)
        {
            this.Hide();
            REDEFINIRSENHA rEDEFINIRSENHA = new REDEFINIRSENHA();
            rEDEFINIRSENHA.ShowDialog();

        }
    }
}
