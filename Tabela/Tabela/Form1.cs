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

namespace Tabela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand();
            comm.Connection = Banco.abrir();
            comm.CommandText = "insert curso values ('" + txtNome.Text + "'," + txtCarga.Text + ")";
            comm.ExecuteNonQuery();//grava registros na tabela
            comm.CommandText = "select @@identity";
            txtID.Text = comm.ExecuteScalar().ToString();
            comm.Connection.Close();
            MessageBox.Show("Curso " + txtID.Text + " gravado");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
