namespace ProjetoAmigo.view
{
    partial class FrmPresidente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresidente));
            System.Windows.Forms.Label codpresidenteLabel;
            System.Windows.Forms.Label nomepresidenteLabel;
            System.Windows.Forms.Label codpartidofkLabel;
            this.amigoDataSet = new ProjetoAmigo.amigoDataSet();
            this.presidenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presidenteTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.presidenteTableAdapter();
            this.tableAdapterManager = new ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager();
            this.presidenteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.presidenteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partidoTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.partidoTableAdapter();
            this.codpresidenteLabel1 = new System.Windows.Forms.Label();
            this.nomepresidenteTextBox = new System.Windows.Forms.TextBox();
            this.codpartidofkComboBox = new System.Windows.Forms.ComboBox();
            this.partidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dados_presidenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dados_presidenteTableAdapter = new ProjetoAmigo.amigoDataSetTableAdapters.dados_presidenteTableAdapter();
            this.dados_presidenteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codpresidenteLabel = new System.Windows.Forms.Label();
            nomepresidenteLabel = new System.Windows.Forms.Label();
            codpartidofkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidenteBindingNavigator)).BeginInit();
            this.presidenteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_presidenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_presidenteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amigoDataSet
            // 
            this.amigoDataSet.DataSetName = "amigoDataSet";
            this.amigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.presidenteTableAdapter = this.presidenteTableAdapter;
            this.tableAdapterManager.ruaTableAdapter = null;
            this.tableAdapterManager.sexoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoAmigo.amigoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // presidenteBindingNavigator
            // 
            this.presidenteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.presidenteBindingNavigator.BindingSource = this.presidenteBindingSource;
            this.presidenteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.presidenteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.presidenteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.presidenteBindingNavigatorSaveItem});
            this.presidenteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.presidenteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.presidenteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.presidenteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.presidenteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.presidenteBindingNavigator.Name = "presidenteBindingNavigator";
            this.presidenteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.presidenteBindingNavigator.Size = new System.Drawing.Size(586, 25);
            this.presidenteBindingNavigator.TabIndex = 0;
            this.presidenteBindingNavigator.Text = "bindingNavigator1";
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
            // presidenteBindingNavigatorSaveItem
            // 
            this.presidenteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.presidenteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("presidenteBindingNavigatorSaveItem.Image")));
            this.presidenteBindingNavigatorSaveItem.Name = "presidenteBindingNavigatorSaveItem";
            this.presidenteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.presidenteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.presidenteBindingNavigatorSaveItem.Click += new System.EventHandler(this.presidenteBindingNavigatorSaveItem_Click);
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
            // codpresidenteLabel
            // 
            codpresidenteLabel.AutoSize = true;
            codpresidenteLabel.Location = new System.Drawing.Point(15, 38);
            codpresidenteLabel.Name = "codpresidenteLabel";
            codpresidenteLabel.Size = new System.Drawing.Size(77, 13);
            codpresidenteLabel.TabIndex = 1;
            codpresidenteLabel.Text = "codpresidente:";
            // 
            // codpresidenteLabel1
            // 
            this.codpresidenteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presidenteBindingSource, "codpresidente", true));
            this.codpresidenteLabel1.Location = new System.Drawing.Point(106, 38);
            this.codpresidenteLabel1.Name = "codpresidenteLabel1";
            this.codpresidenteLabel1.Size = new System.Drawing.Size(121, 23);
            this.codpresidenteLabel1.TabIndex = 2;
            this.codpresidenteLabel1.Text = "label1";
            // 
            // nomepresidenteLabel
            // 
            nomepresidenteLabel.AutoSize = true;
            nomepresidenteLabel.Location = new System.Drawing.Point(15, 67);
            nomepresidenteLabel.Name = "nomepresidenteLabel";
            nomepresidenteLabel.Size = new System.Drawing.Size(85, 13);
            nomepresidenteLabel.TabIndex = 3;
            nomepresidenteLabel.Text = "nomepresidente:";
            // 
            // nomepresidenteTextBox
            // 
            this.nomepresidenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presidenteBindingSource, "nomepresidente", true));
            this.nomepresidenteTextBox.Location = new System.Drawing.Point(106, 64);
            this.nomepresidenteTextBox.Name = "nomepresidenteTextBox";
            this.nomepresidenteTextBox.Size = new System.Drawing.Size(256, 20);
            this.nomepresidenteTextBox.TabIndex = 4;
            // 
            // codpartidofkLabel
            // 
            codpartidofkLabel.AutoSize = true;
            codpartidofkLabel.Location = new System.Drawing.Point(15, 93);
            codpartidofkLabel.Name = "codpartidofkLabel";
            codpartidofkLabel.Size = new System.Drawing.Size(69, 13);
            codpartidofkLabel.TabIndex = 5;
            codpartidofkLabel.Text = "codpartidofk:";
            // 
            // codpartidofkComboBox
            // 
            this.codpartidofkComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.presidenteBindingSource, "codpartidofk", true));
            this.codpartidofkComboBox.DataSource = this.partidoBindingSource1;
            this.codpartidofkComboBox.DisplayMember = "siglapartido";
            this.codpartidofkComboBox.FormattingEnabled = true;
            this.codpartidofkComboBox.Location = new System.Drawing.Point(106, 90);
            this.codpartidofkComboBox.Name = "codpartidofkComboBox";
            this.codpartidofkComboBox.Size = new System.Drawing.Size(121, 21);
            this.codpartidofkComboBox.TabIndex = 6;
            this.codpartidofkComboBox.ValueMember = "codpartido";
            // 
            // partidoBindingSource1
            // 
            this.partidoBindingSource1.DataMember = "partido";
            this.partidoBindingSource1.DataSource = this.amigoDataSet;
            // 
            // dados_presidenteBindingSource
            // 
            this.dados_presidenteBindingSource.DataMember = "dados_presidente";
            this.dados_presidenteBindingSource.DataSource = this.amigoDataSet;
            // 
            // dados_presidenteTableAdapter
            // 
            this.dados_presidenteTableAdapter.ClearBeforeFill = true;
            // 
            // dados_presidenteDataGridView
            // 
            this.dados_presidenteDataGridView.AutoGenerateColumns = false;
            this.dados_presidenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados_presidenteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dados_presidenteDataGridView.DataSource = this.dados_presidenteBindingSource;
            this.dados_presidenteDataGridView.Location = new System.Drawing.Point(18, 117);
            this.dados_presidenteDataGridView.Name = "dados_presidenteDataGridView";
            this.dados_presidenteDataGridView.Size = new System.Drawing.Size(544, 220);
            this.dados_presidenteDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codpresidente";
            this.dataGridViewTextBoxColumn2.HeaderText = "codpresidente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nomepresidente";
            this.dataGridViewTextBoxColumn3.HeaderText = "nomepresidente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "siglapartido";
            this.dataGridViewTextBoxColumn4.HeaderText = "siglapartido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FrmPresidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 351);
            this.Controls.Add(this.dados_presidenteDataGridView);
            this.Controls.Add(codpresidenteLabel);
            this.Controls.Add(this.codpresidenteLabel1);
            this.Controls.Add(nomepresidenteLabel);
            this.Controls.Add(this.nomepresidenteTextBox);
            this.Controls.Add(codpartidofkLabel);
            this.Controls.Add(this.codpartidofkComboBox);
            this.Controls.Add(this.presidenteBindingNavigator);
            this.Name = "FrmPresidente";
            this.Text = "FrmPresidente";
            this.Load += new System.EventHandler(this.FrmPresidente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amigoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidenteBindingNavigator)).EndInit();
            this.presidenteBindingNavigator.ResumeLayout(false);
            this.presidenteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_presidenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_presidenteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private amigoDataSet amigoDataSet;
        private System.Windows.Forms.BindingSource presidenteBindingSource;
        private amigoDataSetTableAdapters.presidenteTableAdapter presidenteTableAdapter;
        private amigoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator presidenteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton presidenteBindingNavigatorSaveItem;
        private amigoDataSetTableAdapters.partidoTableAdapter partidoTableAdapter;
        private System.Windows.Forms.BindingSource partidoBindingSource;
        private System.Windows.Forms.Label codpresidenteLabel1;
        private System.Windows.Forms.TextBox nomepresidenteTextBox;
        private System.Windows.Forms.ComboBox codpartidofkComboBox;
        private System.Windows.Forms.BindingSource partidoBindingSource1;
        private System.Windows.Forms.BindingSource dados_presidenteBindingSource;
        private amigoDataSetTableAdapters.dados_presidenteTableAdapter dados_presidenteTableAdapter;
        private System.Windows.Forms.DataGridView dados_presidenteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}