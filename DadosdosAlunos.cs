using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DadosdosAlunos : Form
    {
        public DadosdosAlunos()
        {
            InitializeComponent();
        }

        private void DadosdosAlunos_Load(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora frmcalculadore = new Calculadora();
            frmcalculadore.Show();
        }
    }
}
