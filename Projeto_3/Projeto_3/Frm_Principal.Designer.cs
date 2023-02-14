namespace Projeto_3
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mnu_Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.fera = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Cadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Produtos = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_empresa = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnu_Vendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Arquivo,
            this.Mnu_Cadastros,
            this.Mnu_Sobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mnu_Arquivo
            // 
            this.Mnu_Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fera});
            this.Mnu_Arquivo.Name = "Mnu_Arquivo";
            this.Mnu_Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Mnu_Arquivo.Text = "&Arquivo";
            // 
            // fera
            // 
            this.fera.Image = ((System.Drawing.Image)(resources.GetObject("fera.Image")));
            this.fera.Name = "fera";
            this.fera.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.fera.Size = new System.Drawing.Size(180, 22);
            this.fera.Text = "&Sair";
            this.fera.Click += new System.EventHandler(this.fera_Click);
            // 
            // Mnu_Cadastros
            // 
            this.Mnu_Cadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_Clientes,
            this.Mnu_Produtos,
            this.Mnu_Vendas});
            this.Mnu_Cadastros.Name = "Mnu_Cadastros";
            this.Mnu_Cadastros.Size = new System.Drawing.Size(71, 20);
            this.Mnu_Cadastros.Text = "&Cadastros";
            // 
            // Mnu_Clientes
            // 
            this.Mnu_Clientes.Name = "Mnu_Clientes";
            this.Mnu_Clientes.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.Mnu_Clientes.Size = new System.Drawing.Size(186, 22);
            this.Mnu_Clientes.Text = "&Clientes";
            // 
            // Mnu_Produtos
            // 
            this.Mnu_Produtos.Name = "Mnu_Produtos";
            this.Mnu_Produtos.Size = new System.Drawing.Size(186, 22);
            this.Mnu_Produtos.Text = "Produtos";
            // 
            // Mnu_Sobre
            // 
            this.Mnu_Sobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnu_empresa});
            this.Mnu_Sobre.Name = "Mnu_Sobre";
            this.Mnu_Sobre.Size = new System.Drawing.Size(49, 20);
            this.Mnu_Sobre.Text = "Sobre";
            // 
            // Mnu_empresa
            // 
            this.Mnu_empresa.Name = "Mnu_empresa";
            this.Mnu_empresa.Size = new System.Drawing.Size(180, 22);
            this.Mnu_empresa.Text = "Empresa";
            // 
            // Mnu_Vendas
            // 
            this.Mnu_Vendas.Name = "Mnu_Vendas";
            this.Mnu_Vendas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.Mnu_Vendas.Size = new System.Drawing.Size(186, 22);
            this.Mnu_Vendas.Text = "&Vendas";
            this.Mnu_Vendas.Click += new System.EventHandler(this.Mnu_Vendas_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 376);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo 14/02/2023";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem fera;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Cadastros;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Clientes;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Produtos;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Sobre;
        private System.Windows.Forms.ToolStripMenuItem Mnu_empresa;
        private System.Windows.Forms.ToolStripMenuItem Mnu_Vendas;
    }
}

