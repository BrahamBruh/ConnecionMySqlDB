using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnecionMySqlCSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datos = "";
            string server = ServidorTxt.Text;
            string port = Puertotxt.Text;
            string usuario = Usuariotxt.Text;
            string password = Passwordtxt.Text;

            string StringCon = "server=" + server + ";" + "port=" + port + ";" + "user id=" + usuario + ";" + "password="+password+";"+"database=sqldb;";

            MySqlConnection conexionDB = new MySqlConnection(StringCon);
            try { 
                conexionDB.Open();
                MySqlDataReader reader = null;

                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES",conexionDB);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0)+"\n";

                }
            }
            catch(MySqlException ex) {
                MessageBox.Show(ex.Message);
            
            }
            MessageBox.Show(datos);

        }
    }
}
