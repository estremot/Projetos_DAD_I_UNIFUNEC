using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAmigo.view
{
    public partial class FrmAmigo : Form
    {
        public FrmAmigo()
        {
            InitializeComponent();
        }

        private void amigoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.amigoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.amigoDataSet);

        }

        private void FrmAmigo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.dados_amigo'. Você pode movê-la ou removê-la conforme necessário.
            this.dados_amigoTableAdapter.Fill(this.amigoDataSet.dados_amigo);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.pais'. Você pode movê-la ou removê-la conforme necessário.
            this.paisTableAdapter.Fill(this.amigoDataSet.pais);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.cep'. Você pode movê-la ou removê-la conforme necessário.
            this.cepTableAdapter.Fill(this.amigoDataSet.cep);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.bairro'. Você pode movê-la ou removê-la conforme necessário.
            this.bairroTableAdapter.Fill(this.amigoDataSet.bairro);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.rua'. Você pode movê-la ou removê-la conforme necessário.
            this.ruaTableAdapter.Fill(this.amigoDataSet.rua);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.estado'. Você pode movê-la ou removê-la conforme necessário.
            this.estadoTableAdapter.Fill(this.amigoDataSet.estado);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.cidade'. Você pode movê-la ou removê-la conforme necessário.
            this.cidadeTableAdapter.Fill(this.amigoDataSet.cidade);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.sexo'. Você pode movê-la ou removê-la conforme necessário.
            this.sexoTableAdapter.Fill(this.amigoDataSet.sexo);
            // TODO: esta linha de código carrega dados na tabela 'amigoDataSet.amigo'. Você pode movê-la ou removê-la conforme necessário.
            this.amigoTableAdapter.Fill(this.amigoDataSet.amigo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSexo frm = new FrmSexo();
            frm.ShowDialog();
        }

        private void codcepfkComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEstado frm = new FrmEstado();    
            frm.ShowDialog();
        }

        private void FrmAmigo_Enter(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-RN0Q3J7;Initial Catalog=amigo;Integrated Security=True";
            con.Open();
            SqlCommand sql = new SqlCommand();
            sql.Connection = con;
            sql.CommandText = "SELECT * FROM estado";
            SqlDataReader dr = sql.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(dr);

            codestadofkComboBox.DisplayMember = "nomestado";
            codestadofkComboBox.DataSource = tb;
        }
    }
}
