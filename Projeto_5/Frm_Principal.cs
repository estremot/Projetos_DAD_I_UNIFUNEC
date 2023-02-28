using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_5
{
    public partial class Frm_Principal : Form
    {
        //Declaração de Atributo Público Global
        public double total;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_Masculino_Click(object sender, EventArgs e)
        {
            chb_Prostata.Enabled= true; //ativar a opção prostata


            //desativar exames para o sexo feminino
            if (chb_gravidez.Checked)
            {
                total = Double.Parse(lbl_Total.Text) - 100.89;
            }

            if (chb_Mamografia.Checked)
            {
                total = Double.Parse(lbl_Total.Text) - 712;
            }
            lbl_Total.Text = total.ToString();

            chb_Mamografia.Enabled= false;
            chb_gravidez.Enabled= false;
            chb_gravidez.Checked= false;
            chb_Mamografia.Checked= false;
        }

        private void rdb_Feminino_Click(object sender, EventArgs e)
        {
            //ativar os exames para o sexo feminino
            chb_gravidez.Enabled= true;
            chb_Mamografia.Enabled= true;

            //desativar os exames do sexo masculino
            if (chb_Prostata.Checked)
            {
                total = Double.Parse(lbl_Total.Text) - 80.25;
            }
            lbl_Total.Text=total.ToString();

            chb_Prostata.Enabled= false;
            chb_Prostata.Checked= false;
        }

        private void chb_Coracao_Click(object sender, EventArgs e)
        {
            if (chb_Coracao.Checked)
            {
                total = Double.Parse(lbl_Total.Text) + 500.25;
            }
            else
            {
                total = Double.Parse(lbl_Total.Text) - 500.25;
            }

            lbl_Total.Text = total.ToString();
        }

        private void chb_gravidez_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_gravidez_Click(object sender, EventArgs e)
        {
            if (chb_gravidez.Checked)
            {
                total = Double.Parse(lbl_Total.Text) + 100.89;
            }
            else
            {
                total = Double.Parse(lbl_Total.Text) - 100.89;
            }

            lbl_Total.Text = total.ToString();
        }

        private void chb_Prostata_Click(object sender, EventArgs e)
        {
            if (chb_Prostata.Checked)
            {
                total = Double.Parse(lbl_Total.Text) + 80.25;
            }
            else
            {
                total = Double.Parse(lbl_Total.Text) - 80.25;
            }

            lbl_Total.Text = total.ToString();
        }

        private void chb_Sangue_Click(object sender, EventArgs e)
        {
            if (chb_Sangue.Checked)
            {
                total = Double.Parse(lbl_Total.Text) + 15;
            }
            else
            {
                total = Double.Parse(lbl_Total.Text) - 15;
            }

            lbl_Total.Text = total.ToString();
        }

        private void chb_Mamografia_Click(object sender, EventArgs e)
        {
            if (chb_Mamografia.Checked)
            {
                total = Double.Parse(lbl_Total.Text) + 712;
            }
            else
            {
                total = Double.Parse(lbl_Total.Text) - 712;
            }

            lbl_Total.Text = total.ToString();
        }

        private void chb_Ortopedico_Click(object sender, EventArgs e)
        {
            if (chb_Ortopedico.Checked)
            {
                total = Double.Parse(lbl_Total.Text) + 87;
            }
            else
            {
                total = Double.Parse(lbl_Total.Text) - 87;
            }

            lbl_Total.Text = total.ToString();
        }
    }
}
