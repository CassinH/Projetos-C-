using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adicionar_Tabela
{
    public partial class Form1 : Form
    {
       public int num;
        public Form1()
        {
            InitializeComponent();
            num = 0;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            if(tx_name.Text == "")
            {
                MessageBox.Show("Digite um valor");
                tx_name.Focus();
                return;
            }
            tx_resultado.Text += tx_name.Text + ',';
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            tx_resultado.Clear();
            tx_name.Clear();
            tx_name.Focus();

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            Resultado result = new Resultado (tx_resultado.Text,this);
            result.ShowDialog();
        }

        private void Tx_valor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckBox Box = new CheckBox();
            Box.ShowDialog();
        }

        private void mostrarListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Resultado result = new Resultado(tx_resultado.Text, this);
            result.ShowDialog();
        }
    }
}
