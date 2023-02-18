using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void mnu_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair da Aplicação?", "Projeto 4", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sobre frm_sobre = new Frm_Sobre();
            frm_sobre.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void mnu_conversao_Click(object sender, EventArgs e)
        {
            Frm_Conversao frm_conversao = new Frm_Conversao();
            frm_conversao.ShowDialog();
        }
    }
}
