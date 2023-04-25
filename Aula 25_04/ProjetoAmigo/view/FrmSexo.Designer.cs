namespace ProjetoAmigo.view
{
    partial class FrmSexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSexo));
            System.Windows.Forms.Label codsexoLabel;
            System.Windows.Forms.Label nomesexoLabel;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.sexoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexoTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.sexoTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.sexoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sexoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codsexoLabel1 = new System.Windows.Forms.Label();
            this.nomesexoTextBox = new System.Windows.Forms.TextBox();
            this.sexoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codsexoLabel = new System.Windows.Forms.Label();
            nomesexoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingNavigator)).BeginInit();
            this.sexoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexoBindingSource
            // 
            this.sexoBindingSource.DataMember = "sexo";
            this.sexoBindingSource.DataSource = this.amigoDataSet;
            // 
            // sexoTableAdapter
            // 
            this.sexoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.partidoTableAdapter = null;
            this.tableAdapterManager.presidenteTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = this.sexoTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sexoBindingNavigator
            // 
            this.sexoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sexoBindingNavigator.BindingSource = this.sexoBindingSource;
            this.sexoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sexoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sexoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sexoBindingNavigatorSaveItem});
            this.sexoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sexoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sexoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sexoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sexoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sexoBindingNavigator.Name = "sexoBindingNavigator";
            this.sexoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sexoBindingNavigator.Size = new System.Drawing.Size(382, 25);
            this.sexoBindingNavigator.TabIndex = 0;
            this.sexoBindingNavigator.Text = "bindingNavigator1";
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
            // sexoBindingNavigatorSaveItem
            // 
            this.sexoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sexoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sexoBindingNavigatorSaveItem.Image")));
            this.sexoBindingNavigatorSaveItem.Name = "sexoBindingNavigatorSaveItem";
            this.sexoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sexoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.sexoBindingNavigatorSaveItem.Click += new System.EventHandler(this.sexoBindingNavigatorSaveItem_Click);
            // 
            // codsexoLabel
            // 
            codsexoLabel.AutoSize = true;
            codsexoLabel.Location = new System.Drawing.Point(20, 37);
            codsexoLabel.Name = "codsexoLabel";
            codsexoLabel.Size = new System.Drawing.Size(43, 13);
            codsexoLabel.TabIndex = 1;
            codsexoLabel.Text = "Código:";
            // 
            // codsexoLabel1
            // 
            this.codsexoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sexoBindingSource, "codsexo", true));
            this.codsexoLabel1.Location = new System.Drawing.Point(84, 37);
            this.codsexoLabel1.Name = "codsexoLabel1";
            this.codsexoLabel1.Size = new System.Drawing.Size(100, 23);
            this.codsexoLabel1.TabIndex = 2;
            this.codsexoLabel1.Text = "label1";
            // 
            // nomesexoLabel
            // 
            nomesexoLabel.AutoSize = true;
            nomesexoLabel.Location = new System.Drawing.Point(20, 66);
            nomesexoLabel.Name = "nomesexoLabel";
            nomesexoLabel.Size = new System.Drawing.Size(34, 13);
            nomesexoLabel.TabIndex = 3;
            nomesexoLabel.Text = "Sexo:";
            // 
            // nomesexoTextBox
            // 
            this.nomesexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sexoBindingSource, "nomesexo", true));
            this.nomesexoTextBox.Location = new System.Drawing.Point(84, 63);
            this.nomesexoTextBox.Name = "nomesexoTextBox";
            this.nomesexoTextBox.Size = new System.Drawing.Size(193, 20);
            this.nomesexoTextBox.TabIndex = 4;
            // 
            // sexoDataGridView
            // 
            this.sexoDataGridView.AutoGenerateColumns = false;
            this.sexoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sexoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sexoDataGridView.DataSource = this.sexoBindingSource;
            this.sexoDataGridView.Location = new System.Drawing.Point(23, 98);
            this.sexoDataGridView.Name = "sexoDataGridView";
            this.sexoDataGridView.Size = new System.Drawing.Size(327, 220);
            this.sexoDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codsexo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codsexo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomesexo";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomesexo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FrmSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 345);
            this.Controls.Add(this.sexoDataGridView);
            this.Controls.Add(codsexoLabel);
            this.Controls.Add(this.codsexoLabel1);
            this.Controls.Add(nomesexoLabel);
            this.Controls.Add(this.nomesexoTextBox);
            this.Controls.Add(this.sexoBindingNavigator);
            this.Name = "FrmSexo";
            this.Text = "FrmSexo";
            this.Load += new System.EventHandler(this.FrmSexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexoBindingNavigator)).EndInit();
            this.sexoBindingNavigator.ResumeLayout(false);
            this.sexoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sexoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource sexoBindingSource;
        private amigoDataSetTableAdapters.sexoTableAdapter sexoTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sexoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sexoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codsexoLabel1;
        private System.Windows.Forms.TextBox nomesexoTextBox;
        private System.Windows.Forms.DataGridView sexoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}