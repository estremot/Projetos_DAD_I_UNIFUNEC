using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_9_UC_
{
    public partial class Form1 : Form
    {
        int contaForm2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void formulario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl1 u = new UserControl1();
            
            TabPage tabPage = new TabPage();
            tabPage.Name = "Form2";
            tabPage.Text = "Form 2: "+contaForm2;
            tabPage.Controls.Add(u);

            tbc_Janelas.TabPages.Add(tabPage);
            contaForm2++;
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbc_Janelas.TabPages.Remove(tbc_Janelas.SelectedTab);
        }
    }
}
