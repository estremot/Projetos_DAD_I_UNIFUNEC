using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_1_Forms
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Somar_Click(object sender, EventArgs e)
        {
            int v1 = Int32.Parse(txt_Valor1.Text);
            int v2 = Int32.Parse(txt_Valor2.Text);
            int total = v1 + v2;

            lbl_Total.Text = total.ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Valor1.Text = "";
            txt_Valor2.Text= "";
            lbl_Total.Text = "";
        }
    }
}
