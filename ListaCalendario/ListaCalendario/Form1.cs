using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCalendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nomeUsuario,cidade;
            DateTime dataNascimento;
            bool sexoM,sexoF;



            nomeUsuario = textBox1.Text;
            cidade = comboBox1.Text;
            dataNascimento = dateTimePicker1.Value;
            sexoM = radioButton1.Checked;
            sexoF = radioButton2.Checked;

            MessageBox.Show("Nome:" + nomeUsuario);
            MessageBox.Show("Data de Nascimento:" + dataNascimento);
            MessageBox.Show("Cidade:" + cidade);
            MessageBox.Show("Sexo Masculino:" + sexoM);
            MessageBox.Show("Sexo Masculino:" + sexoF);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
