namespace Projeto_4
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
            this.components = new System.ComponentModel.Container();
            this.Mnu_Aplicacao = new System.Windows.Forms.MenuStrip();
            this.mnu_Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Projetos = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_conversao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Mnu_Aplicacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_Aplicacao
            // 
            this.Mnu_Aplicacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Arquivo,
            this.mnu_Projetos,
            this.sobreToolStripMenuItem});
            this.Mnu_Aplicacao.Location = new System.Drawing.Point(0, 0);
            this.Mnu_Aplicacao.Name = "Mnu_Aplicacao";
            this.Mnu_Aplicacao.Size = new System.Drawing.Size(587, 24);
            this.Mnu_Aplicacao.TabIndex = 0;
            this.Mnu_Aplicacao.Text = "menuStrip1";
            // 
            // mnu_Arquivo
            // 
            this.mnu_Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Sair});
            this.mnu_Arquivo.Name = "mnu_Arquivo";
            this.mnu_Arquivo.Size = new System.Drawing.Size(61, 20);
            this.mnu_Arquivo.Text = "&Arquivo";
            // 
            // mnu_Projetos
            // 
            this.mnu_Projetos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_conversao});
            this.mnu_Projetos.Name = "mnu_Projetos";
            this.mnu_Projetos.Size = new System.Drawing.Size(62, 20);
            this.mnu_Projetos.Text = "&Projetos";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "So&bre";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresaToolStripMenuItem.Text = "&Empresa";
            this.empresaToolStripMenuItem.ToolTipText = "Dados sobre o Desenvolvedor do Sistema";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // mnu_conversao
            // 
            this.mnu_conversao.Name = "mnu_conversao";
            this.mnu_conversao.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mnu_conversao.Size = new System.Drawing.Size(180, 22);
            this.mnu_conversao.Text = "&Conversão";
            this.mnu_conversao.ToolTipText = "Converte Metros para Centímetros";
            this.mnu_conversao.Click += new System.EventHandler(this.mnu_conversao_Click);
            // 
            // mnu_Sair
            // 
            this.mnu_Sair.Name = "mnu_Sair";
            this.mnu_Sair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.mnu_Sair.Size = new System.Drawing.Size(180, 22);
            this.mnu_Sair.Text = "&Sair";
            this.mnu_Sair.ToolTipText = "Sair da Aplicação";
            this.mnu_Sair.Click += new System.EventHandler(this.mnu_Sair_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mnu_Aplicacao);
            this.MainMenuStrip = this.Mnu_Aplicacao;
            this.Name = "Frm_Principal";
            this.Text = "Projeto 4 - UNIFUNEC 2023";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Mnu_Aplicacao.ResumeLayout(false);
            this.Mnu_Aplicacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_Aplicacao;
        private System.Windows.Forms.ToolStripMenuItem mnu_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem mnu_Sair;
        private System.Windows.Forms.ToolStripMenuItem mnu_Projetos;
        private System.Windows.Forms.ToolStripMenuItem mnu_conversao;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

