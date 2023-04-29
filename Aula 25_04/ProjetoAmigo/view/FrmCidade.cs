using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAmigo.view
{
    public partial class FrmCidade : Form
    {
        public FrmCidade()
        {
            InitializeComponent();
        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.amigoDataSet.cidade);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
