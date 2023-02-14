using Projeto_3.Controle;
using Projeto_3.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3.Visao
{
    public partial class Frm_Venda : Form
    {
        public Frm_Venda()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Venda v = new Venda(); //criação do objeto

            v.Nome = txt_Nome.Text;
            v.Quantidade = Double.Parse(txt_Quantidade.Text);
            v.Valor = Double.Parse(txt_Valor.Text);

            C_Venda cv = new C_Venda();

            v = cv.calculaVenda(v);

            lbl_total.Text = v.Total.ToString();
        }
    }
}
