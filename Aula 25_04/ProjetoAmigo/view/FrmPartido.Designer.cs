namespace ProjetoAmigo.view
{
    partial class FrmPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartido));
            System.Windows.Forms.Label codpartidoLabel;
            System.Windows.Forms.Label nomepartidoLabel;
            System.Windows.Forms.Label siglapartidoLabel;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.partidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partidoTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.partidoTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.partidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.partidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codpartidoLabel1 = new System.Windows.Forms.Label();
            this.nomepartidoTextBox = new System.Windows.Forms.TextBox();
            this.siglapartidoTextBox = new System.Windows.Forms.TextBox();
            this.partidoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codpartidoLabel = new System.Windows.Forms.Label();
            nomepartidoLabel = new System.Windows.Forms.Label();
            siglapartidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidoBindingNavigator)).BeginInit();
            this.partidoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partidoBindingSource
            // 
            this.partidoBindingSource.DataMember = "partido";
            this.partidoBindingSource.DataSource = this.amigoDataSet;
            // 
            // partidoTableAdapter
            // 
            this.partidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.amigoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.paisTableAdapter = null;
            this.tableAdapterManager.partidoTableAdapter = this.partidoTableAdapter;
            this.tableAdapterManager.presidenteTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partidoBindingNavigator
            // 
            this.partidoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partidoBindingNavigator.BindingSource = this.partidoBindingSource;
            this.partidoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partidoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.partidoBindingNavigatorSaveItem});
            this.partidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partidoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partidoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partidoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partidoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partidoBindingNavigator.Name = "partidoBindingNavigator";
            this.partidoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partidoBindingNavigator.Size = new System.Drawing.Size(595, 25);
            this.partidoBindingNavigator.TabIndex = 0;
            this.partidoBindingNavigator.Text = "bindingNavigator1";
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
            // partidoBindingNavigatorSaveItem
            // 
            this.partidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partidoBindingNavigatorSaveItem.Image")));
            this.partidoBindingNavigatorSaveItem.Name = "partidoBindingNavigatorSaveItem";
            this.partidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.partidoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.partidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.partidoBindingNavigatorSaveItem_Click);
            // 
            // codpartidoLabel
            // 
            codpartidoLabel.AutoSize = true;
            codpartidoLabel.Location = new System.Drawing.Point(12, 37);
            codpartidoLabel.Name = "codpartidoLabel";
            codpartidoLabel.Size = new System.Drawing.Size(60, 13);
            codpartidoLabel.TabIndex = 1;
            codpartidoLabel.Text = "codpartido:";
            // 
            // codpartidoLabel1
            // 
            this.codpartidoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidoBindingSource, "codpartido", true));
            this.codpartidoLabel1.Location = new System.Drawing.Point(86, 37);
            this.codpartidoLabel1.Name = "codpartidoLabel1";
            this.codpartidoLabel1.Size = new System.Drawing.Size(100, 23);
            this.codpartidoLabel1.TabIndex = 2;
            this.codpartidoLabel1.Text = "label1";
            // 
            // nomepartidoLabel
            // 
            nomepartidoLabel.AutoSize = true;
            nomepartidoLabel.Location = new System.Drawing.Point(12, 66);
            nomepartidoLabel.Name = "nomepartidoLabel";
            nomepartidoLabel.Size = new System.Drawing.Size(68, 13);
            nomepartidoLabel.TabIndex = 3;
            nomepartidoLabel.Text = "nomepartido:";
            // 
            // nomepartidoTextBox
            // 
            this.nomepartidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidoBindingSource, "nomepartido", true));
            this.nomepartidoTextBox.Location = new System.Drawing.Point(86, 63);
            this.nomepartidoTextBox.Name = "nomepartidoTextBox";
            this.nomepartidoTextBox.Size = new System.Drawing.Size(307, 20);
            this.nomepartidoTextBox.TabIndex = 4;
            // 
            // siglapartidoLabel
            // 
            siglapartidoLabel.AutoSize = true;
            siglapartidoLabel.Location = new System.Drawing.Point(12, 92);
            siglapartidoLabel.Name = "siglapartidoLabel";
            siglapartidoLabel.Size = new System.Drawing.Size(63, 13);
            siglapartidoLabel.TabIndex = 5;
            siglapartidoLabel.Text = "siglapartido:";
            // 
            // siglapartidoTextBox
            // 
            this.siglapartidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partidoBindingSource, "siglapartido", true));
            this.siglapartidoTextBox.Location = new System.Drawing.Point(86, 89);
            this.siglapartidoTextBox.Name = "siglapartidoTextBox";
            this.siglapartidoTextBox.Size = new System.Drawing.Size(140, 20);
            this.siglapartidoTextBox.TabIndex = 6;
            // 
            // partidoDataGridView
            // 
            this.partidoDataGridView.AutoGenerateColumns = false;
            this.partidoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partidoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.partidoDataGridView.DataSource = this.partidoBindingSource;
            this.partidoDataGridView.Location = new System.Drawing.Point(12, 115);
            this.partidoDataGridView.Name = "partidoDataGridView";
            this.partidoDataGridView.Size = new System.Drawing.Size(567, 220);
            this.partidoDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codpartido";
            this.dataGridViewTextBoxColumn1.HeaderText = "codpartido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomepartido";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomepartido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "siglapartido";
            this.dataGridViewTextBoxColumn3.HeaderText = "siglapartido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FrmPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 345);
            this.Controls.Add(this.partidoDataGridView);
            this.Controls.Add(codpartidoLabel);
            this.Controls.Add(this.codpartidoLabel1);
            this.Controls.Add(nomepartidoLabel);
            this.Controls.Add(this.nomepartidoTextBox);
            this.Controls.Add(siglapartidoLabel);
            this.Controls.Add(this.siglapartidoTextBox);
            this.Controls.Add(this.partidoBindingNavigator);
            this.Name = "FrmPartido";
            this.Text = "FrmPartido";
            this.Load += new System.EventHandler(this.FrmPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidoBindingNavigator)).EndInit();
            this.partidoBindingNavigator.ResumeLayout(false);
            this.partidoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource partidoBindingSource;
        private amigoDataSetTableAdapters.partidoTableAdapter partidoTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partidoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton partidoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codpartidoLabel1;
        private System.Windows.Forms.TextBox nomepartidoTextBox;
        private System.Windows.Forms.TextBox siglapartidoTextBox;
        private System.Windows.Forms.DataGridView partidoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}