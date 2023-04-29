namespace ProjetoAmigo.view
{
    partial class FrmEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstado));
            System.Windows.Forms.Label codestadoLabel;
            System.Windows.Forms.Label nomeestadoLabel;
            System.Windows.Forms.Label siglaLabel;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.estadoTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.estadoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.estadoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codestadoLabel1 = new System.Windows.Forms.Label();
            this.nomeestadoTextBox = new System.Windows.Forms.TextBox();
            this.siglaTextBox = new System.Windows.Forms.TextBox();
            this.estadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            codestadoLabel = new System.Windows.Forms.Label();
            nomeestadoLabel = new System.Windows.Forms.Label();
            siglaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingNavigator)).BeginInit();
            this.estadoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "estado";
            this.estadoBindingSource.DataSource = this.amigoDataSet;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.amigoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = this.estadoTableAdapter;
            this.tableAdapterManager.paisTableAdapter = null;
            this.tableAdapterManager.partidoTableAdapter = null;
            this.tableAdapterManager.presidenteTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // estadoBindingNavigator
            // 
            this.estadoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.estadoBindingNavigator.BindingSource = this.estadoBindingSource;
            this.estadoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.estadoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.estadoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estadoBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.estadoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estadoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.estadoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.estadoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.estadoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.estadoBindingNavigator.Name = "estadoBindingNavigator";
            this.estadoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.estadoBindingNavigator.Size = new System.Drawing.Size(490, 25);
            this.estadoBindingNavigator.TabIndex = 0;
            this.estadoBindingNavigator.Text = "bindingNavigator1";
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
            // estadoBindingNavigatorSaveItem
            // 
            this.estadoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estadoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estadoBindingNavigatorSaveItem.Image")));
            this.estadoBindingNavigatorSaveItem.Name = "estadoBindingNavigatorSaveItem";
            this.estadoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.estadoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.estadoBindingNavigatorSaveItem.Click += new System.EventHandler(this.estadoBindingNavigatorSaveItem_Click);
            // 
            // codestadoLabel
            // 
            codestadoLabel.AutoSize = true;
            codestadoLabel.Location = new System.Drawing.Point(10, 47);
            codestadoLabel.Name = "codestadoLabel";
            codestadoLabel.Size = new System.Drawing.Size(60, 13);
            codestadoLabel.TabIndex = 1;
            codestadoLabel.Text = "codestado:";
            // 
            // codestadoLabel1
            // 
            this.codestadoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadoBindingSource, "codestado", true));
            this.codestadoLabel1.Location = new System.Drawing.Point(84, 47);
            this.codestadoLabel1.Name = "codestadoLabel1";
            this.codestadoLabel1.Size = new System.Drawing.Size(100, 23);
            this.codestadoLabel1.TabIndex = 2;
            this.codestadoLabel1.Text = "label1";
            // 
            // nomeestadoLabel
            // 
            nomeestadoLabel.AutoSize = true;
            nomeestadoLabel.Location = new System.Drawing.Point(10, 76);
            nomeestadoLabel.Name = "nomeestadoLabel";
            nomeestadoLabel.Size = new System.Drawing.Size(68, 13);
            nomeestadoLabel.TabIndex = 3;
            nomeestadoLabel.Text = "nomeestado:";
            // 
            // nomeestadoTextBox
            // 
            this.nomeestadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadoBindingSource, "nomeestado", true));
            this.nomeestadoTextBox.Location = new System.Drawing.Point(84, 73);
            this.nomeestadoTextBox.Name = "nomeestadoTextBox";
            this.nomeestadoTextBox.Size = new System.Drawing.Size(381, 20);
            this.nomeestadoTextBox.TabIndex = 4;
            // 
            // siglaLabel
            // 
            siglaLabel.AutoSize = true;
            siglaLabel.Location = new System.Drawing.Point(10, 102);
            siglaLabel.Name = "siglaLabel";
            siglaLabel.Size = new System.Drawing.Size(31, 13);
            siglaLabel.TabIndex = 5;
            siglaLabel.Text = "sigla:";
            // 
            // siglaTextBox
            // 
            this.siglaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadoBindingSource, "sigla", true));
            this.siglaTextBox.Location = new System.Drawing.Point(84, 99);
            this.siglaTextBox.Name = "siglaTextBox";
            this.siglaTextBox.Size = new System.Drawing.Size(100, 20);
            this.siglaTextBox.TabIndex = 6;
            // 
            // estadoDataGridView
            // 
            this.estadoDataGridView.AutoGenerateColumns = false;
            this.estadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.estadoDataGridView.DataSource = this.estadoBindingSource;
            this.estadoDataGridView.Location = new System.Drawing.Point(13, 125);
            this.estadoDataGridView.Name = "estadoDataGridView";
            this.estadoDataGridView.Size = new System.Drawing.Size(452, 220);
            this.estadoDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codestado";
            this.dataGridViewTextBoxColumn1.HeaderText = "codestado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeestado";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomeestado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sigla";
            this.dataGridViewTextBoxColumn3.HeaderText = "sigla";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel1.Text = "Atualizar";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // FrmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 390);
            this.Controls.Add(this.estadoDataGridView);
            this.Controls.Add(codestadoLabel);
            this.Controls.Add(this.codestadoLabel1);
            this.Controls.Add(nomeestadoLabel);
            this.Controls.Add(this.nomeestadoTextBox);
            this.Controls.Add(siglaLabel);
            this.Controls.Add(this.siglaTextBox);
            this.Controls.Add(this.estadoBindingNavigator);
            this.Name = "FrmEstado";
            this.Text = "FrmEstado";
            this.Load += new System.EventHandler(this.FrmEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingNavigator)).EndInit();
            this.estadoBindingNavigator.ResumeLayout(false);
            this.estadoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private amigoDataSetTableAdapters.estadoTableAdapter estadoTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estadoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estadoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codestadoLabel1;
        private System.Windows.Forms.TextBox nomeestadoTextBox;
        private System.Windows.Forms.TextBox siglaTextBox;
        private System.Windows.Forms.DataGridView estadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}