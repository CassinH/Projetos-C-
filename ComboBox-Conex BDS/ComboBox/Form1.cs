using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ("server=127.0.0.1;user id=Cassio;persistsecurityinfo=True;database=test; password=Cassio001");
            cn.Open();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = cn;
            cm.CommandText = "select nome from cliente";
            MySqlDataReader dr = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBox1.DisplayMember = "nome";
            comboBox1.DataSource = dt;
        }
    }
}
