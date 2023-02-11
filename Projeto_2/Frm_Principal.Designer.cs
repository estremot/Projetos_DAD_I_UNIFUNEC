namespace Projeto_2
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
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nota1 = new System.Windows.Forms.Label();
            this.lbl_Nota2 = new System.Windows.Forms.Label();
            this.txt_Nota1 = new System.Windows.Forms.TextBox();
            this.txt_Nota2 = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.pnl_Total = new System.Windows.Forms.Panel();
            this.lbl_Situacao = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_resp_situacao = new System.Windows.Forms.Label();
            this.pnl_Total.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sair.Image")));
            this.Btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair.Location = new System.Drawing.Point(369, 238);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(88, 30);
            this.Btn_Sair.TabIndex = 0;
            this.Btn_Sair.Text = "&Sair";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULA MÉDIA";
            // 
            // lbl_Nota1
            // 
            this.lbl_Nota1.AutoSize = true;
            this.lbl_Nota1.Location = new System.Drawing.Point(33, 82);
            this.lbl_Nota1.Name = "lbl_Nota1";
            this.lbl_Nota1.Size = new System.Drawing.Size(42, 13);
            this.lbl_Nota1.TabIndex = 2;
            this.lbl_Nota1.Text = "Nota 1:";
            // 
            // lbl_Nota2
            // 
            this.lbl_Nota2.AutoSize = true;
            this.lbl_Nota2.Location = new System.Drawing.Point(33, 124);
            this.lbl_Nota2.Name = "lbl_Nota2";
            this.lbl_Nota2.Size = new System.Drawing.Size(42, 13);
            this.lbl_Nota2.TabIndex = 3;
            this.lbl_Nota2.Text = "Nota 2:";
            // 
            // txt_Nota1
            // 
            this.txt_Nota1.Location = new System.Drawing.Point(36, 98);
            this.txt_Nota1.Name = "txt_Nota1";
            this.txt_Nota1.Size = new System.Drawing.Size(230, 20);
            this.txt_Nota1.TabIndex = 4;
            this.txt_Nota1.Leave += new System.EventHandler(this.txt_Nota1_Leave);
            // 
            // txt_Nota2
            // 
            this.txt_Nota2.Location = new System.Drawing.Point(33, 140);
            this.txt_Nota2.Name = "txt_Nota2";
            this.txt_Nota2.Size = new System.Drawing.Size(233, 20);
            this.txt_Nota2.TabIndex = 5;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(272, 98);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 62);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "&Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(353, 98);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 62);
            this.btn_Limpar.TabIndex = 7;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // pnl_Total
            // 
            this.pnl_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Total.Controls.Add(this.lbl_resp_situacao);
            this.pnl_Total.Controls.Add(this.lbl_Total);
            this.pnl_Total.Controls.Add(this.lbl_Situacao);
            this.pnl_Total.Location = new System.Drawing.Point(33, 168);
            this.pnl_Total.Name = "pnl_Total";
            this.pnl_Total.Size = new System.Drawing.Size(233, 100);
            this.pnl_Total.TabIndex = 8;
            // 
            // lbl_Situacao
            // 
            this.lbl_Situacao.AutoSize = true;
            this.lbl_Situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Situacao.Location = new System.Drawing.Point(6, 11);
            this.lbl_Situacao.Name = "lbl_Situacao";
            this.lbl_Situacao.Size = new System.Drawing.Size(90, 20);
            this.lbl_Situacao.TabIndex = 0;
            this.lbl_Situacao.Text = "Situação: ";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(104, 38);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(122, 55);
            this.lbl_Total.TabIndex = 1;
            this.lbl_Total.Text = "0,00";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbl_resp_situacao
            // 
            this.lbl_resp_situacao.AutoSize = true;
            this.lbl_resp_situacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resp_situacao.Location = new System.Drawing.Point(93, 11);
            this.lbl_resp_situacao.Name = "lbl_resp_situacao";
            this.lbl_resp_situacao.Size = new System.Drawing.Size(57, 20);
            this.lbl_resp_situacao.TabIndex = 2;
            this.lbl_resp_situacao.Text = "label2";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 280);
            this.Controls.Add(this.pnl_Total);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Nota2);
            this.Controls.Add(this.txt_Nota1);
            this.Controls.Add(this.lbl_Nota2);
            this.Controls.Add(this.lbl_Nota1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Sair);
            this.Name = "Frm_Principal";
            this.Text = "Projeto 2 - UNIFUNEC";
            this.pnl_Total.ResumeLayout(false);
            this.pnl_Total.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nota1;
        private System.Windows.Forms.Label lbl_Nota2;
        private System.Windows.Forms.TextBox txt_Nota1;
        private System.Windows.Forms.TextBox txt_Nota2;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Panel pnl_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Situacao;
        private System.Windows.Forms.Label lbl_resp_situacao;
    }
}

