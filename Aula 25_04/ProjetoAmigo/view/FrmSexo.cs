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
    public partial class FrmSexo : Form
    {
        public FrmSexo()
        {
            InitializeComponent();
        }

        private void sexoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sexoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmSexo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.amigoDataSet.sexo);

        }
    }
}
