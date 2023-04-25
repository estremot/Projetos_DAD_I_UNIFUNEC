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
    public partial class FrmPresidente : Form
    {
        public FrmPresidente()
        {
            InitializeComponent();
        }

        private void presidenteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.presidenteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmPresidente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.dados_presidente'. Você pode movê-la ou removê-la conforme necessário.
            this.dados_presidenteTableAdapter.Fill(this.amigoDataSet.dados_presidente);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.partido'. Você pode movê-la ou removê-la conforme necessário.
            this.partidoTableAdapter.Fill(this.amigoDataSet.partido);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.presidente'. Você pode movê-la ou removê-la conforme necessário.
            this.presidenteTableAdapter.Fill(this.amigoDataSet.presidente);

        }
    }
}
