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
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox2.LostFocus += TextBox2_LostFocus;


        }
        private void TextBox2_LostFocus(object sender, EventArgs e)
        {
            // Chama a função veremail() quando o TextBox perder o foco
            veremail();
        }

        private void veremail()
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

                string sql;
                sql = "select Email from Usuarios where Email = @email ";
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = textBox2.Text;

                cmd.CommandText = sql;
                cmd.Connection = con;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    panel1.BackColor = Color.Red;
                    Label label = new Label();
                    label.Text = "Email ja cadastrado";
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.ForeColor = System.Drawing.Color.White;
                    
                    label.Width = panel1.Width;
                    panel1.Controls.Add(label);
                }
                else
                {
                    panel1.Visible = false;
                }
            }
            catch (SqlException erro)
            {
                MessageBox.Show("" + erro);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);

        }
    }
}
