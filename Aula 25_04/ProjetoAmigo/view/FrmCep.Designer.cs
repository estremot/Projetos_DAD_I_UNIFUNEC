namespace ProjetoAmigo.view
{
    partial class FrmCep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCep));
            System.Windows.Forms.Label codcepLabel;
            System.Windows.Forms.Label numerocepLabel;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.cepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cepTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.cepTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.cepBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cepBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codcepLabel1 = new System.Windows.Forms.Label();
            this.numerocepTextBox = new System.Windows.Forms.TextBox();
            this.cepDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codcepLabel = new System.Windows.Forms.Label();
            numerocepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingNavigator)).BeginInit();
            this.cepBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cepDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cepBindingSource
            // 
            this.cepBindingSource.DataMember = "cep";
            this.cepBindingSource.DataSource = this.amigoDataSet;
            // 
            // cepTableAdapter
            // 
            this.cepTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.amigoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = this.cepTableAdapter;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.paisTableAdapter = null;
            this.tableAdapterManager.partidoTableAdapter = null;
            this.tableAdapterManager.presidenteTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cepBindingNavigator
            // 
            this.cepBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cepBindingNavigator.BindingSource = this.cepBindingSource;
            this.cepBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cepBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cepBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cepBindingNavigatorSaveItem});
            this.cepBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cepBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cepBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cepBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cepBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cepBindingNavigator.Name = "cepBindingNavigator";
            this.cepBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cepBindingNavigator.Size = new System.Drawing.Size(383, 25);
            this.cepBindingNavigator.TabIndex = 0;
            this.cepBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // cepBindingNavigatorSaveItem
            // 
            this.cepBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cepBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cepBindingNavigatorSaveItem.Image")));
            this.cepBindingNavigatorSaveItem.Name = "cepBindingNavigatorSaveItem";
            this.cepBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cepBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cepBindingNavigatorSaveItem.Click += new System.EventHandler(this.cepBindingNavigatorSaveItem_Click);
            // 
            // codcepLabel
            // 
            codcepLabel.AutoSize = true;
            codcepLabel.Location = new System.Drawing.Point(10, 41);
            codcepLabel.Name = "codcepLabel";
            codcepLabel.Size = new System.Drawing.Size(46, 13);
            codcepLabel.TabIndex = 1;
            codcepLabel.Text = "codcep:";
            // 
            // codcepLabel1
            // 
            this.codcepLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cepBindingSource, "codcep", true));
            this.codcepLabel1.Location = new System.Drawing.Point(79, 41);
            this.codcepLabel1.Name = "codcepLabel1";
            this.codcepLabel1.Size = new System.Drawing.Size(100, 23);
            this.codcepLabel1.TabIndex = 2;
            this.codcepLabel1.Text = "label1";
            // 
            // numerocepLabel
            // 
            numerocepLabel.AutoSize = true;
            numerocepLabel.Location = new System.Drawing.Point(10, 70);
            numerocepLabel.Name = "numerocepLabel";
            numerocepLabel.Size = new System.Drawing.Size(63, 13);
            numerocepLabel.TabIndex = 3;
            numerocepLabel.Text = "numerocep:";
            // 
            // numerocepTextBox
            // 
            this.numerocepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cepBindingSource, "numerocep", true));
            this.numerocepTextBox.Location = new System.Drawing.Point(79, 67);
            this.numerocepTextBox.Name = "numerocepTextBox";
            this.numerocepTextBox.Size = new System.Drawing.Size(100, 20);
            this.numerocepTextBox.TabIndex = 4;
            // 
            // cepDataGridView
            // 
            this.cepDataGridView.AutoGenerateColumns = false;
            this.cepDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cepDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cepDataGridView.DataSource = this.cepBindingSource;
            this.cepDataGridView.Location = new System.Drawing.Point(13, 93);
            this.cepDataGridView.Name = "cepDataGridView";
            this.cepDataGridView.Size = new System.Drawing.Size(353, 220);
            this.cepDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codcep";
            this.dataGridViewTextBoxColumn1.HeaderText = "codcep";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numerocep";
            this.dataGridViewTextBoxColumn2.HeaderText = "numerocep";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FrmCep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 329);
            this.Controls.Add(this.cepDataGridView);
            this.Controls.Add(codcepLabel);
            this.Controls.Add(this.codcepLabel1);
            this.Controls.Add(numerocepLabel);
            this.Controls.Add(this.numerocepTextBox);
            this.Controls.Add(this.cepBindingNavigator);
            this.Name = "FrmCep";
            this.Text = "FrmCep";
            this.Load += new System.EventHandler(this.FrmCep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cepBindingNavigator)).EndInit();
            this.cepBindingNavigator.ResumeLayout(false);
            this.cepBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cepDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource cepBindingSource;
        private amigoDataSetTableAdapters.cepTableAdapter cepTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cepBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cepBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codcepLabel1;
        private System.Windows.Forms.TextBox numerocepTextBox;
        private System.Windows.Forms.DataGridView cepDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}