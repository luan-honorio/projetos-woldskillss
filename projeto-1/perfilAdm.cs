using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class perfilAdm : Form
    {
        public perfilAdm(string id_usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            SqlConnection cn;
            string sqlcon;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            sqlcon = @"Data source= DESKTOP-B8E4I0L\SQLEXPRESS; integrated security=SSPI; Initial catalog=registros ";
            cn = new SqlConnection(sqlcon);
            cn.Open();


            string sql;
            sql = "select  foto,id_genero, id_perfil, nome,  telefone,email,endereco,senha from usuario where id_usuario = @id_usuario ";
            cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Convert.ToInt32(id_usuario);

            cmd.Connection = cn;
            cmd.CommandText = sql;
            dr = cmd.ExecuteReader();



            dr.Read();

            string genero = dr["id_genero"].ToString();
            string conta = dr["id_perfil"].ToString();

            if (genero == "1")
            {
                label6.Text = "Genero: Masculino";

            }
            else if (genero == "2")
            {
                label6.Text = "Genero: Feminino";
            }
            else
            {
                label6.Text = "Genero: Outro";
            }

            if (conta == "1")
            {
                label7.Text = "Administrador";
            }
            else
            {
                label7.Text = "Usuario comum";
            }


            label1.Text = dr["nome"].ToString();
            label2.Text = dr["telefone"].ToString();
            label3.Text = dr["email"].ToString();
            label4.Text = dr["endereco"].ToString();
            label5.Text = dr["senha"].ToString();


            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            long len = dr.GetBytes(0, 0, null, 0, 0);
            byte[] array = new byte[System.Convert.ToInt32(len) + 1];
            dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
            MemoryStream ms = new MemoryStream(array);
            Bitmap bmp = new Bitmap(ms);
            pictureBox1.BackgroundImage = bmp;


            System.Drawing.Drawing2D.GraphicsPath forma = new System.Drawing.Drawing2D.GraphicsPath();
            forma.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Region = new System.Drawing.Region(forma);




            button3.Click += (s, e) =>
            {
                this.Hide();
                homeAdm  homeAdm= new homeAdm(id_usuario);
                homeAdm.ShowDialog();
            };

        }

        private void perfilAdm_Load(object sender, EventArgs e)
        {

        }
    }
}
