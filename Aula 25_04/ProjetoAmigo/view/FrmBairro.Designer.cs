namespace ProjetoAmigo.view
{
    partial class FrmBairro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBairro));
            System.Windows.Forms.Label codbairroLabel;
            System.Windows.Forms.Label nomebairroLabel;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.bairroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bairroTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.bairroTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.bairroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bairroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codbairroLabel1 = new System.Windows.Forms.Label();
            this.nomebairroTextBox = new System.Windows.Forms.TextBox();
            this.bairroDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codbairroLabel = new System.Windows.Forms.Label();
            nomebairroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingNavigator)).BeginInit();
            this.bairroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bairroDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bairroBindingSource
            // 
            this.bairroBindingSource.DataMember = "bairro";
            this.bairroBindingSource.DataSource = this.amigoDataSet;
            // 
            // bairroTableAdapter
            // 
            this.bairroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.amigoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = this.bairroTableAdapter;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.paisTableAdapter = null;
            this.tableAdapterManager.partidoTableAdapter = null;
            this.tableAdapterManager.presidenteTableAdapter = null;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bairroBindingNavigator
            // 
            this.bairroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bairroBindingNavigator.BindingSource = this.bairroBindingSource;
            this.bairroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bairroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bairroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bairroBindingNavigatorSaveItem});
            this.bairroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bairroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bairroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bairroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bairroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bairroBindingNavigator.Name = "bairroBindingNavigator";
            this.bairroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bairroBindingNavigator.Size = new System.Drawing.Size(404, 25);
            this.bairroBindingNavigator.TabIndex = 0;
            this.bairroBindingNavigator.Text = "bindingNavigator1";
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
            // bairroBindingNavigatorSaveItem
            // 
            this.bairroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bairroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bairroBindingNavigatorSaveItem.Image")));
            this.bairroBindingNavigatorSaveItem.Name = "bairroBindingNavigatorSaveItem";
            this.bairroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bairroBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.bairroBindingNavigatorSaveItem.Click += new System.EventHandler(this.bairroBindingNavigatorSaveItem_Click);
            // 
            // codbairroLabel
            // 
            codbairroLabel.AutoSize = true;
            codbairroLabel.Location = new System.Drawing.Point(10, 46);
            codbairroLabel.Name = "codbairroLabel";
            codbairroLabel.Size = new System.Drawing.Size(54, 13);
            codbairroLabel.TabIndex = 1;
            codbairroLabel.Text = "codbairro:";
            // 
            // codbairroLabel1
            // 
            this.codbairroLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bairroBindingSource, "codbairro", true));
            this.codbairroLabel1.Location = new System.Drawing.Point(78, 46);
            this.codbairroLabel1.Name = "codbairroLabel1";
            this.codbairroLabel1.Size = new System.Drawing.Size(100, 23);
            this.codbairroLabel1.TabIndex = 2;
            this.codbairroLabel1.Text = "label1";
            // 
            // nomebairroLabel
            // 
            nomebairroLabel.AutoSize = true;
            nomebairroLabel.Location = new System.Drawing.Point(10, 75);
            nomebairroLabel.Name = "nomebairroLabel";
            nomebairroLabel.Size = new System.Drawing.Size(62, 13);
            nomebairroLabel.TabIndex = 3;
            nomebairroLabel.Text = "nomebairro:";
            // 
            // nomebairroTextBox
            // 
            this.nomebairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bairroBindingSource, "nomebairro", true));
            this.nomebairroTextBox.Location = new System.Drawing.Point(78, 72);
            this.nomebairroTextBox.Name = "nomebairroTextBox";
            this.nomebairroTextBox.Size = new System.Drawing.Size(302, 20);
            this.nomebairroTextBox.TabIndex = 4;
            // 
            // bairroDataGridView
            // 
            this.bairroDataGridView.AutoGenerateColumns = false;
            this.bairroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bairroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bairroDataGridView.DataSource = this.bairroBindingSource;
            this.bairroDataGridView.Location = new System.Drawing.Point(12, 113);
            this.bairroDataGridView.Name = "bairroDataGridView";
            this.bairroDataGridView.Size = new System.Drawing.Size(368, 220);
            this.bairroDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codbairro";
            this.dataGridViewTextBoxColumn1.HeaderText = "codbairro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomebairro";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomebairro";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // FrmBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 358);
            this.Controls.Add(this.bairroDataGridView);
            this.Controls.Add(codbairroLabel);
            this.Controls.Add(this.codbairroLabel1);
            this.Controls.Add(nomebairroLabel);
            this.Controls.Add(this.nomebairroTextBox);
            this.Controls.Add(this.bairroBindingNavigator);
            this.Name = "FrmBairro";
            this.Text = "FrmBairro";
            this.Load += new System.EventHandler(this.FrmBairro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bairroBindingNavigator)).EndInit();
            this.bairroBindingNavigator.ResumeLayout(false);
            this.bairroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bairroDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource bairroBindingSource;
        private amigoDataSetTableAdapters.bairroTableAdapter bairroTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bairroBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bairroBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codbairroLabel1;
        private System.Windows.Forms.TextBox nomebairroTextBox;
        private System.Windows.Forms.DataGridView bairroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}