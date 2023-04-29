namespace ProjetoAmigo.view
{
    partial class FrmCidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCidade));
            System.Windows.Forms.Label nomecidadeLabel;
            System.Windows.Forms.Label codcidadeLabel;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.cidadeTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.cidadeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cidadeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nomecidadeTextBox = new System.Windows.Forms.TextBox();
            this.codcidadeLabel1 = new System.Windows.Forms.Label();
            this.cidadeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            nomecidadeLabel = new System.Windows.Forms.Label();
            codcidadeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingNavigator)).BeginInit();
            this.cidadeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this.amigoDataSet;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.amigoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = this.cidadeTableAdapter;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.paisTableAdapter = null;
            this.tableAdapterManager.partidoTableAdapter = null;
            this.tableAdapterManager.presidenteTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cidadeBindingNavigator
            // 
            this.cidadeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cidadeBindingNavigator.BindingSource = this.cidadeBindingSource;
            this.cidadeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cidadeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cidadeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cidadeBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.cidadeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cidadeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cidadeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cidadeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cidadeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cidadeBindingNavigator.Name = "cidadeBindingNavigator";
            this.cidadeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cidadeBindingNavigator.Size = new System.Drawing.Size(480, 25);
            this.cidadeBindingNavigator.TabIndex = 0;
            this.cidadeBindingNavigator.Text = "bindingNavigator1";
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
            // cidadeBindingNavigatorSaveItem
            // 
            this.cidadeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cidadeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cidadeBindingNavigatorSaveItem.Image")));
            this.cidadeBindingNavigatorSaveItem.Name = "cidadeBindingNavigatorSaveItem";
            this.cidadeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.cidadeBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cidadeBindingNavigatorSaveItem.Click += new System.EventHandler(this.cidadeBindingNavigatorSaveItem_Click);
            // 
            // nomecidadeLabel
            // 
            nomecidadeLabel.AutoSize = true;
            nomecidadeLabel.Location = new System.Drawing.Point(15, 73);
            nomecidadeLabel.Name = "nomecidadeLabel";
            nomecidadeLabel.Size = new System.Drawing.Size(68, 13);
            nomecidadeLabel.TabIndex = 3;
            nomecidadeLabel.Text = "nomecidade:";
            // 
            // nomecidadeTextBox
            // 
            this.nomecidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadeBindingSource, "nomecidade", true));
            this.nomecidadeTextBox.Location = new System.Drawing.Point(89, 70);
            this.nomecidadeTextBox.Name = "nomecidadeTextBox";
            this.nomecidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomecidadeTextBox.TabIndex = 4;
            // 
            // codcidadeLabel
            // 
            codcidadeLabel.AutoSize = true;
            codcidadeLabel.Location = new System.Drawing.Point(20, 44);
            codcidadeLabel.Name = "codcidadeLabel";
            codcidadeLabel.Size = new System.Drawing.Size(60, 13);
            codcidadeLabel.TabIndex = 4;
            codcidadeLabel.Text = "codcidade:";
            // 
            // codcidadeLabel1
            // 
            this.codcidadeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadeBindingSource, "codcidade", true));
            this.codcidadeLabel1.Location = new System.Drawing.Point(86, 44);
            this.codcidadeLabel1.Name = "codcidadeLabel1";
            this.codcidadeLabel1.Size = new System.Drawing.Size(100, 23);
            this.codcidadeLabel1.TabIndex = 5;
            this.codcidadeLabel1.Text = "label1";
            // 
            // cidadeDataGridView
            // 
            this.cidadeDataGridView.AutoGenerateColumns = false;
            this.cidadeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cidadeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cidadeDataGridView.DataSource = this.cidadeBindingSource;
            this.cidadeDataGridView.Location = new System.Drawing.Point(18, 96);
            this.cidadeDataGridView.Name = "cidadeDataGridView";
            this.cidadeDataGridView.Size = new System.Drawing.Size(438, 220);
            this.cidadeDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codcidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "codcidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomecidade";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomecidade";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Fechar";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // FrmCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 371);
            this.Controls.Add(this.cidadeDataGridView);
            this.Controls.Add(codcidadeLabel);
            this.Controls.Add(this.codcidadeLabel1);
            this.Controls.Add(nomecidadeLabel);
            this.Controls.Add(this.nomecidadeTextBox);
            this.Controls.Add(this.cidadeBindingNavigator);
            this.Name = "FrmCidade";
            this.Text = "FrmCidade";
            this.Load += new System.EventHandler(this.FrmCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingNavigator)).EndInit();
            this.cidadeBindingNavigator.ResumeLayout(false);
            this.cidadeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private amigoDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cidadeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cidadeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomecidadeTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label codcidadeLabel1;
        private System.Windows.Forms.DataGridView cidadeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}