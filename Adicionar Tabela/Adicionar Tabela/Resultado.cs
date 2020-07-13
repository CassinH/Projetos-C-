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
    public partial class Resultado : Form
    {
        Form1 fp;
        public Resultado(String v, Form1 f)
        {
            InitializeComponent();

            tx_resultado.Text = v;
            fp = f;
            fp.num = 10;

        }

        
        
        private void Resultado_Load(object sender, EventArgs e)
        {

        }

        private void tx_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.ShowDialog();
        }
    }
}
