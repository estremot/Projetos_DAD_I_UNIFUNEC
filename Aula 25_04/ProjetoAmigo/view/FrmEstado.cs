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
    public partial class FrmEstado : Form
    {
        public FrmEstado()
        {
            InitializeComponent();
        }

        private void estadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.estado'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoTableAdapter.Fill(this.amigoDataSet.estado);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
