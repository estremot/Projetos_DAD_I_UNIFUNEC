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
    public partial class FrmBairro : Form
    {
        public FrmBairro()
        {
            InitializeComponent();
        }

        private void bairroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bairroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmBairro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.amigoDataSet.bairro);

        }
    }
}
