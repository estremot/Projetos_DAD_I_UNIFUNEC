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
    public partial class FrmCep : Form
    {
        public FrmCep()
        {
            InitializeComponent();
        }

        private void cepBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cepBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmCep_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.amigoDataSet.cep);

        }
    }
}
