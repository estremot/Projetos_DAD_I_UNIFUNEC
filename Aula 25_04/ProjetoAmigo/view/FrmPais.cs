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
    public partial class FrmPais : Form
    {
        public FrmPais()
        {
            InitializeComponent();
        }

        private void paisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.dados_pais'. Você pode movê-la ou removê-la conforme necessário.
            this.dados_paisTableAdapter.Fill(this.amigoDataSet.dados_pais);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.presidente'. Você pode movê-la ou removê-la conforme necessário.
            this.presidenteTableAdapter.Fill(this.amigoDataSet.presidente);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.pais'. Você pode movê-la ou removê-la conforme necessário.
            this.paisTableAdapter.Fill(this.amigoDataSet.pais);

        }
    }
}
