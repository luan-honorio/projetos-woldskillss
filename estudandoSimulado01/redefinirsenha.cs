using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudandoSimulado01
{
    public partial class redefinirsenha : Form
    {
        public redefinirsenha(string email)
        {
             this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

                SqlConnection con;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                string sqlcon;
                sqlcon = @"DATA SOURCE=DESKTOP-ISNQG64\SQLEXPRESS ; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=Sessao5";
                con = new SqlConnection(sqlcon);
                cmd.Connection = con;
                cmd.CommandText = sqlcon;
                con.Open();

                string sql;
                sql = "select Nome, id from Selecoes";
                cmd.CommandText = sql;
                cmd.Connection = con;
                dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                timefavorito.Items.Add(dr["Nome"].ToString());
            }
            

        }

        private void recuperarsenhas()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                string sqlcon;
                sqlcon = @"DATA SOURCE=DESKTOP-ISNQG64\SQLEXPRESS ; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=Sessao5";
                con = new SqlConnection(sqlcon);
                cmd.Connection = con;
                cmd.CommandText = sqlcon;
                con.Open();

                MessageBox.Show("conect");
                
            }catch(SqlException erro)
            {
                MessageBox.Show("erro");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.Length <8)
            {
                panel1.BackColor = Color.Red;
                Label label1 = new Label();
                label1.Text = "Baixo";
                panel1.Controls.Add(label1);
            }
            verificarsenha();
        }

        private void verificarsenha()
        {
            if(textBox1.Text != textBox2.Text)
            {
                panel2.BackColor = Color.Red;
                Label label1 = new Label();
                label1.Text = "senha incorreta";
                panel2.Controls.Add(label1);
            }
            else{
                panel2.BackColor= Color.Green;
                Label label2 = new Label();
                label2.Text = "senhas Identicas";
                panel2.Controls.Add(label2);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            verificarsenha();
        }
    }
   
}
