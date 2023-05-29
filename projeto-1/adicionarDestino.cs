using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class adicionarDestino : Form
    {
        public adicionarDestino(string id_usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            button3.Click += (s, args) =>
            {
                homeAdm homeAdm = new homeAdm(id_usuario);
                homeAdm.ShowDialog();
            };

            button2.Click += (s, args) =>
            {
                perfilUser perfilUser =  new perfilUser(id_usuario);
                perfilUser.ShowDialog();
            };

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);



            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn;
            string sqlcon;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            sqlcon = @"Data source= DESKTOP-B8E4I0L\SQLEXPRESS; integrated security=SSPI; Initial catalog=registros ";
            cn = new SqlConnection(sqlcon);
            cn.Open();


            string sql;
            sql = "insert into destinos(nome,descricao,esdereco,data, foto) values(@nome,@desc,@ender,@data,@foto); ";

            cmd.Connection = cn;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome.Text;
            cmd.Parameters.Add("desc", SqlDbType.VarChar).Value = desc.Text;
            cmd.Parameters.Add("@ender", SqlDbType.VarChar).Value = ender.Text;
            cmd.Parameters.Add("data", SqlDbType.VarChar).Value = data.Text;
            cmd.Parameters.Add("@foto", SqlDbType.Image).Value = foto();


            cmd.CommandText = sql;
            
            dr = cmd.ExecuteReader();
            MessageBox.Show("foto adicinadsa!");


         
        }
       
        private byte[] foto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream,pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }

     

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

  
}
