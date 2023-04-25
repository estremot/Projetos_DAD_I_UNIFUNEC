namespace ProjetoAmigo.view
{
    partial class FrmRua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRua));
            System.Windows.Forms.Label codruaLabel;
            System.Windows.Forms.Label nomeruaLabel;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.ruaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ruaTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.ruaTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.ruaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ruaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codruaLabel1 = new System.Windows.Forms.Label();
            this.nomeruaTextBox = new System.Windows.Forms.TextBox();
            this.ruaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codruaLabel = new System.Windows.Forms.Label();
            nomeruaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingNavigator)).BeginInit();
            this.ruaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ruaBindingSource
            // 
            this.ruaBindingSource.DataMember = "rua";
            this.ruaBindingSource.DataSource = this.amigoDataSet;
            // 
            // ruaTableAdapter
            // 
            this.ruaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ruaTableAdapter = this.ruaTableAdapter;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ruaBindingNavigator
            // 
            this.ruaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ruaBindingNavigator.BindingSource = this.ruaBindingSource;
            this.ruaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ruaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ruaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ruaBindingNavigatorSaveItem});
            this.ruaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ruaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ruaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ruaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ruaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ruaBindingNavigator.Name = "ruaBindingNavigator";
            this.ruaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ruaBindingNavigator.Size = new System.Drawing.Size(545, 25);
            this.ruaBindingNavigator.TabIndex = 0;
            this.ruaBindingNavigator.Text = "bindingNavigator1";
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
            // ruaBindingNavigatorSaveItem
            // 
            this.ruaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ruaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ruaBindingNavigatorSaveItem.Image")));
            this.ruaBindingNavigatorSaveItem.Name = "ruaBindingNavigatorSaveItem";
            this.ruaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ruaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.ruaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ruaBindingNavigatorSaveItem_Click);
            // 
            // codruaLabel
            // 
            codruaLabel.AutoSize = true;
            codruaLabel.Location = new System.Drawing.Point(18, 35);
            codruaLabel.Name = "codruaLabel";
            codruaLabel.Size = new System.Drawing.Size(43, 13);
            codruaLabel.TabIndex = 1;
            codruaLabel.Text = "codrua:";
            // 
            // codruaLabel1
            // 
            this.codruaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruaBindingSource, "codrua", true));
            this.codruaLabel1.Location = new System.Drawing.Point(75, 35);
            this.codruaLabel1.Name = "codruaLabel1";
            this.codruaLabel1.Size = new System.Drawing.Size(100, 23);
            this.codruaLabel1.TabIndex = 2;
            this.codruaLabel1.Text = "label1";
            // 
            // nomeruaLabel
            // 
            nomeruaLabel.AutoSize = true;
            nomeruaLabel.Location = new System.Drawing.Point(18, 64);
            nomeruaLabel.Name = "nomeruaLabel";
            nomeruaLabel.Size = new System.Drawing.Size(51, 13);
            nomeruaLabel.TabIndex = 3;
            nomeruaLabel.Text = "nomerua:";
            // 
            // nomeruaTextBox
            // 
            this.nomeruaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ruaBindingSource, "nomerua", true));
            this.nomeruaTextBox.Location = new System.Drawing.Point(75, 61);
            this.nomeruaTextBox.Name = "nomeruaTextBox";
            this.nomeruaTextBox.Size = new System.Drawing.Size(456, 20);
            this.nomeruaTextBox.TabIndex = 4;
            // 
            // ruaDataGridView
            // 
            this.ruaDataGridView.AutoGenerateColumns = false;
            this.ruaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ruaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ruaDataGridView.DataSource = this.ruaBindingSource;
            this.ruaDataGridView.Location = new System.Drawing.Point(21, 87);
            this.ruaDataGridView.Name = "ruaDataGridView";
            this.ruaDataGridView.Size = new System.Drawing.Size(510, 220);
            this.ruaDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codrua";
            this.dataGridViewTextBoxColumn1.HeaderText = "codrua";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomerua";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomerua";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // FrmRua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 316);
            this.Controls.Add(this.ruaDataGridView);
            this.Controls.Add(codruaLabel);
            this.Controls.Add(this.codruaLabel1);
            this.Controls.Add(nomeruaLabel);
            this.Controls.Add(this.nomeruaTextBox);
            this.Controls.Add(this.ruaBindingNavigator);
            this.Name = "FrmRua";
            this.Text = "FrmRua";
            this.Load += new System.EventHandler(this.FrmRua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruaBindingNavigator)).EndInit();
            this.ruaBindingNavigator.ResumeLayout(false);
            this.ruaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ruaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource ruaBindingSource;
        private amigoDataSetTableAdapters.ruaTableAdapter ruaTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ruaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ruaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codruaLabel1;
        private System.Windows.Forms.TextBox nomeruaTextBox;
        private System.Windows.Forms.DataGridView ruaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}