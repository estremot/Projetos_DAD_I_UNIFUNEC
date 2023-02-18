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
    public partial class Frm_Sobre : Form
    {
        public Frm_Sobre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Descricao.ReadOnly= false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Descricao.ReadOnly= true;
        }

        private void btn_Cor_Titulo_Click(object sender, EventArgs e)
        {
            if (cl_Titulo.ShowDialog() == DialogResult.OK)
            {
                lbl_Titulo.ForeColor = cl_Titulo.Color;
            }
        }

        private void btn_Fonte_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_Titulo.Font = fontDialog1.Font;
                //lbl_Titulo.Size = fontDialog1.Font.Size;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
            }
        }
    }
}
