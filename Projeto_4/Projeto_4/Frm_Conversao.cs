using Projeto_4.Controle;
using Projeto_4.Modelo;
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
    public partial class Frm_Conversao : Form
    {
        public Frm_Conversao()
        {
            InitializeComponent();
        }

        private void btn_Converter_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txt_Metros.Text);
            Calculo dados = new Calculo(m);

            C_Calculo cc = new C_Calculo();
            dados = cc.calcular(dados);

            lbl_Resposta.Text = dados.Centimetros.ToString();
        }
    }
}
