namespace Projeto_1_Forms
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Valor1 = new System.Windows.Forms.Label();
            this.lbl_Valor2 = new System.Windows.Forms.Label();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_Valor2 = new System.Windows.Forms.TextBox();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(73, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(266, 25);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Calcular a Soma de 2 Valores";
            // 
            // lbl_Valor1
            // 
            this.lbl_Valor1.AutoSize = true;
            this.lbl_Valor1.Location = new System.Drawing.Point(19, 53);
            this.lbl_Valor1.Name = "lbl_Valor1";
            this.lbl_Valor1.Size = new System.Drawing.Size(43, 13);
            this.lbl_Valor1.TabIndex = 1;
            this.lbl_Valor1.Text = "Valor 1:";
            // 
            // lbl_Valor2
            // 
            this.lbl_Valor2.AutoSize = true;
            this.lbl_Valor2.Location = new System.Drawing.Point(19, 102);
            this.lbl_Valor2.Name = "lbl_Valor2";
            this.lbl_Valor2.Size = new System.Drawing.Size(43, 13);
            this.lbl_Valor2.TabIndex = 2;
            this.lbl_Valor2.Text = "Valor 2:";
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.Location = new System.Drawing.Point(22, 69);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(145, 20);
            this.txt_Valor1.TabIndex = 3;
            // 
            // txt_Valor2
            // 
            this.txt_Valor2.Location = new System.Drawing.Point(22, 118);
            this.txt_Valor2.Name = "txt_Valor2";
            this.txt_Valor2.Size = new System.Drawing.Size(145, 20);
            this.txt_Valor2.TabIndex = 4;
            // 
            // btn_Somar
            // 
            this.btn_Somar.Location = new System.Drawing.Point(173, 69);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(75, 69);
            this.btn_Somar.TabIndex = 5;
            this.btn_Somar.Text = "&Somar";
            this.btn_Somar.UseVisualStyleBackColor = true;
            this.btn_Somar.Click += new System.EventHandler(this.btn_Somar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(254, 69);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(75, 69);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "&Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Total.Location = new System.Drawing.Point(12, 151);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(219, 86);
            this.lbl_Total.TabIndex = 7;
            this.lbl_Total.Text = "label1";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 246);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Somar);
            this.Controls.Add(this.txt_Valor2);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.lbl_Valor2);
            this.Controls.Add(this.lbl_Valor1);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_Principal";
            this.Text = "Projeto 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Valor1;
        private System.Windows.Forms.Label lbl_Valor2;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_Valor2;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label lbl_Total;
    }
}

