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
    public partial class FrmPartido : Form
    {
        public FrmPartido()
        {
            InitializeComponent();
        }

        private void partidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmPartido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.partido'. Você pode movê-la ou removê-la conforme necessário.
            this.partidoTableAdapter.Fill(this.amigoDataSet.partido);

        }
    }
}
