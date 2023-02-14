using Projeto_3.Visao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_3.Visao;

namespace Projeto_3
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }


        private void fera_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mnu_Vendas_Click(object sender, EventArgs e)
        {
            Frm_Venda frm_Venda= new Frm_Venda();
            frm_Venda.ShowDialog();
        }
    }
}
