        using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class homeUser : Form
    {
        public homeUser(string id_usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            try
            {

                SqlConnection cn;
                string sqlcon;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;


                sqlcon = @"Data source= DESKTOP-B8E4I0L\SQLEXPRESS; integrated security=SSPI; Initial catalog=registros ";
                cn = new SqlConnection(sqlcon);
                cn.Open();


                string sql;
                sql = "select foto,nome, id_destino, descricao,esdereco,data from destinos";

                cmd.Connection = cn;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();



                while (dr.Read())
                {
                    long len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                    PictureBox pic = new PictureBox();
                    pic.Width = 250;
                    pic.Height = 250;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;


                    Label label = new Label();
                    label.Text = dr["nome"].ToString();
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Dock = DockStyle.Top;


                    string id_destino = dr["id_destino"].ToString();
                    string descricao = dr["descricao"].ToString();
                    string data = dr["data"].ToString();
                    string endereco = dr["esdereco"].ToString();

                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bmp = new Bitmap(ms);
                    pic.BackgroundImage = bmp;

                    pic.Controls.Add(label);
                    flowLayoutPanel1.Controls.Add(pic);




                    pic.Click += (s, e) =>
                    {
                        this.Hide();
                        informacoesDestinos informacoes = new informacoesDestinos(label.Text, id_destino, descricao, data, endereco, pic,id_usuario);
                        informacoes.ShowDialog();

                    };

                    button2.Click += (s, e) =>
                    {
                        this.Hide();
                        perfilUser perfilUser = new perfilUser(id_usuario);
                        perfilUser.ShowDialog();
                    };


                }


            }
            catch (SqlException erro)
            {
                MessageBox.Show("pesquisa falhou " + erro);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastro cadastro = new cadastro();
            cadastro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }
    }




}
