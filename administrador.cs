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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace testeprova01
{
    public partial class administrador : Form
    {
        public administrador()
        {
            InitializeComponent();


            SqlConnection conn;
            string sqlcon;

            SqlCommand cmd = new SqlCommand();
            SqlDataReader rdr;


            sqlcon = @"Data source=DESKTOP-ISNQG64\SQLEXPRESS; integrated security=SSPI; initial catalog=teste01";
            conn = new SqlConnection(sqlcon);
            conn.Open();

            string sql;
            sql = "select * from notificacao";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            rdr = cmd.ExecuteReader();
           

            while (rdr.Read())
            {
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.Color.Red;
                panel.Dock = DockStyle.Fill;
                panel.Height = 100;


                Label label = new Label();
                label.Dock = DockStyle.Fill;
               
                label.Text = rdr["titulo"].ToString();   

                panel.Controls.Add(label1);
                flowLayoutPanel1.Controls.Add(panel);
            }




        }
    }
}
