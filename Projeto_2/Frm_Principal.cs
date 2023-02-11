using Projeto_2.Controle;
using Projeto_2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            //Termina a aplicação

            if (MessageBox.Show(
                "Deseja Sair da Bagaça?",
                "Projeto 2",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            if(txt_Nota1.Text == "") { 
                txt_Nota1.Focus();
            }
            else
            {
                if(txt_Nota2.Text == "")
                {
                    txt_Nota2.Focus();
                }
                else
                {

                    double v1 = Double.Parse(txt_Nota1.Text);
                    double v2 = Double.Parse(txt_Nota2.Text);

                    Calculo obj = new Calculo(v1, v2);

                    //Criando o Objeto para o Controle
                    C_Calculo cc = new C_Calculo();

                    obj = cc.calcular(obj);

                    lbl_resp_situacao.Text = obj.Situacao;
                    lbl_Total.Text = obj.Media.ToString();

                    if (obj.Media >= 7)
                    {
                        lbl_resp_situacao.ForeColor = Color.Blue;
                        lbl_Total.ForeColor = Color.Blue;
                    }
                    else
                    {
                        lbl_resp_situacao.ForeColor = Color.Red;
                        lbl_Total.ForeColor = Color.Red;
                    }
                }
            }
            }

        private void txt_Nota1_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
