using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            txt_mascara.Text = "";
            txt_mascara.Mask = "00/00/0000";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            txt_mascara.Text = "";
            txt_mascara.Mask = "(00) 00000-0000";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {

            txt_mascara.Text = "";
            txt_mascara.Mask = "000.000.000-00";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chb_mostrar_Click(object sender, EventArgs e)
        {
            if(chb_mostrar.Checked)
            {
                maskedTextBox5.PasswordChar = '\0';
            }
            else
            {
                maskedTextBox5.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          txt_cidades.Text += (txt_cidade.Text)+"\r\n";
        }
    }
}
