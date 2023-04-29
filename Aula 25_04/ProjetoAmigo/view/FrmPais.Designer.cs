namespace ProjetoAmigo.view
{
    partial class FrmPais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPais));
            System.Windows.Forms.Label codpaisLabel;
            System.Windows.Forms.Label nomepaisLabel;
            System.Windows.Forms.Label codpresidentefkLabel1;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.paisTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.paisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.paisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.codpaisLabel1 = new System.Windows.Forms.Label();
            this.nomepaisTextBox = new System.Windows.Forms.TextBox();
            this.codpresidentefkComboBox = new System.Windows.Forms.ComboBox();
            this.presidenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presidenteTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.presidenteTableAdapter();
            this.dados_paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dados_paisTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.dados_paisTableAdapter();
            this.dados_paisDataGridView = new System.Windows.Forms.DataGridView();
            this.presidenteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codpaisLabel = new System.Windows.Forms.Label();
            nomepaisLabel = new System.Windows.Forms.Label();
            codpresidentefkLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingNavigator)).BeginInit();
            this.paisBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presidenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_paisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidenteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "pais";
            this.paisBindingSource.DataSource = this.amigoDataSet;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.amigoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bairroTableAdapter = null;
            this.tableAdapterManager.cepTableAdapter = null;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.estadoTableAdapter = null;
            this.tableAdapterManager.paisTableAdapter = this.paisTableAdapter;
            this.tableAdapterManager.partidoTableAdapter = null;
            this.tableAdapterManager.presidenteTableAdapter = this.presidenteTableAdapter;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paisBindingNavigator
            // 
            this.paisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paisBindingNavigator.BindingSource = this.paisBindingSource;
            this.paisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paisBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.paisBindingNavigatorSaveItem});
            this.paisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paisBindingNavigator.Name = "paisBindingNavigator";
            this.paisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paisBindingNavigator.Size = new System.Drawing.Size(577, 25);
            this.paisBindingNavigator.TabIndex = 0;
            this.paisBindingNavigator.Text = "bindingNavigator1";
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
            // paisBindingNavigatorSaveItem
            // 
            this.paisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paisBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paisBindingNavigatorSaveItem.Image")));
            this.paisBindingNavigatorSaveItem.Name = "paisBindingNavigatorSaveItem";
            this.paisBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.paisBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.paisBindingNavigatorSaveItem.Click += new System.EventHandler(this.paisBindingNavigatorSaveItem_Click);
            // 
            // codpaisLabel
            // 
            codpaisLabel.AutoSize = true;
            codpaisLabel.Location = new System.Drawing.Point(18, 46);
            codpaisLabel.Name = "codpaisLabel";
            codpaisLabel.Size = new System.Drawing.Size(47, 13);
            codpaisLabel.TabIndex = 1;
            codpaisLabel.Text = "codpais:";
            // 
            // codpaisLabel1
            // 
            this.codpaisLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paisBindingSource, "codpais", true));
            this.codpaisLabel1.Location = new System.Drawing.Point(110, 46);
            this.codpaisLabel1.Name = "codpaisLabel1";
            this.codpaisLabel1.Size = new System.Drawing.Size(100, 23);
            this.codpaisLabel1.TabIndex = 2;
            this.codpaisLabel1.Text = "label1";
            // 
            // nomepaisLabel
            // 
            nomepaisLabel.AutoSize = true;
            nomepaisLabel.Location = new System.Drawing.Point(18, 75);
            nomepaisLabel.Name = "nomepaisLabel";
            nomepaisLabel.Size = new System.Drawing.Size(55, 13);
            nomepaisLabel.TabIndex = 3;
            nomepaisLabel.Text = "nomepais:";
            // 
            // nomepaisTextBox
            // 
            this.nomepaisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paisBindingSource, "nomepais", true));
            this.nomepaisTextBox.Location = new System.Drawing.Point(110, 72);
            this.nomepaisTextBox.Name = "nomepaisTextBox";
            this.nomepaisTextBox.Size = new System.Drawing.Size(443, 20);
            this.nomepaisTextBox.TabIndex = 4;
            // 
            // codpresidentefkLabel1
            // 
            codpresidentefkLabel1.AutoSize = true;
            codpresidentefkLabel1.Location = new System.Drawing.Point(21, 101);
            codpresidentefkLabel1.Name = "codpresidentefkLabel1";
            codpresidentefkLabel1.Size = new System.Drawing.Size(86, 13);
            codpresidentefkLabel1.TabIndex = 6;
            codpresidentefkLabel1.Text = "codpresidentefk:";
            // 
            // codpresidentefkComboBox
            // 
            this.codpresidentefkComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paisBindingSource, "codpresidentefk", true));
            this.codpresidentefkComboBox.DataSource = this.presidenteBindingSource1;
            this.codpresidentefkComboBox.DisplayMember = "nomepresidente";
            this.codpresidentefkComboBox.FormattingEnabled = true;
            this.codpresidentefkComboBox.Location = new System.Drawing.Point(113, 98);
            this.codpresidentefkComboBox.Name = "codpresidentefkComboBox";
            this.codpresidentefkComboBox.Size = new System.Drawing.Size(440, 21);
            this.codpresidentefkComboBox.TabIndex = 7;
            this.codpresidentefkComboBox.ValueMember = "codpresidente";
            // 
            // presidenteBindingSource
            // 
            this.presidenteBindingSource.DataMember = "presidente";
            this.presidenteBindingSource.DataSource = this.amigoDataSet;
            // 
            // presidenteTableAdapter
            // 
            this.presidenteTableAdapter.ClearBeforeFill = true;
            // 
            // dados_paisBindingSource
            // 
            this.dados_paisBindingSource.DataMember = "dados_pais";
            this.dados_paisBindingSource.DataSource = this.amigoDataSet;
            // 
            // dados_paisTableAdapter
            // 
            this.dados_paisTableAdapter.ClearBeforeFill = true;
            // 
            // dados_paisDataGridView
            // 
            this.dados_paisDataGridView.AutoGenerateColumns = false;
            this.dados_paisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados_paisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.dados_paisDataGridView.DataSource = this.dados_paisBindingSource;
            this.dados_paisDataGridView.Location = new System.Drawing.Point(24, 135);
            this.dados_paisDataGridView.Name = "dados_paisDataGridView";
            this.dados_paisDataGridView.Size = new System.Drawing.Size(529, 220);
            this.dados_paisDataGridView.TabIndex = 7;
            // 
            // presidenteBindingSource1
            // 
            this.presidenteBindingSource1.DataMember = "presidente";
            this.presidenteBindingSource1.DataSource = this.amigoDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codpais";
            this.dataGridViewTextBoxColumn3.HeaderText = "codpais";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomepais";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomepais";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nomepresidente";
            this.dataGridViewTextBoxColumn1.HeaderText = "nomepresidente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // FrmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 380);
            this.Controls.Add(this.dados_paisDataGridView);
            this.Controls.Add(codpresidentefkLabel1);
            this.Controls.Add(this.codpresidentefkComboBox);
            this.Controls.Add(codpaisLabel);
            this.Controls.Add(this.codpaisLabel1);
            this.Controls.Add(nomepaisLabel);
            this.Controls.Add(this.nomepaisTextBox);
            this.Controls.Add(this.paisBindingNavigator);
            this.Name = "FrmPais";
            this.Text = "FrmPais";
            this.Load += new System.EventHandler(this.FrmPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingNavigator)).EndInit();
            this.paisBindingNavigator.ResumeLayout(false);
            this.paisBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presidenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_paisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidenteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private amigoDataSetTableAdapters.paisTableAdapter paisTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paisBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton paisBindingNavigatorSaveItem;
        private System.Windows.Forms.Label codpaisLabel1;
        private System.Windows.Forms.TextBox nomepaisTextBox;
        private amigoDataSetTableAdapters.presidenteTableAdapter presidenteTableAdapter;
        private System.Windows.Forms.ComboBox codpresidentefkComboBox;
        private System.Windows.Forms.BindingSource presidenteBindingSource;
        private System.Windows.Forms.BindingSource dados_paisBindingSource;
        private amigoDataSetTableAdapters.dados_paisTableAdapter dados_paisTableAdapter;
        private System.Windows.Forms.BindingSource presidenteBindingSource1;
        private System.Windows.Forms.DataGridView dados_paisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}