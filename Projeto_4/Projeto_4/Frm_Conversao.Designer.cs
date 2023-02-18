namespace Projeto_4
{
    partial class Frm_Conversao
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Metros = new System.Windows.Forms.TextBox();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Resposta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor em Metros";
            // 
            // txt_Metros
            // 
            this.txt_Metros.Location = new System.Drawing.Point(33, 97);
            this.txt_Metros.Name = "txt_Metros";
            this.txt_Metros.Size = new System.Drawing.Size(240, 20);
            this.txt_Metros.TabIndex = 1;
            this.txt_Metros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Converter
            // 
            this.btn_Converter.Location = new System.Drawing.Point(279, 97);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(75, 23);
            this.btn_Converter.TabIndex = 2;
            this.btn_Converter.Text = "Converter";
            this.btn_Converter.UseVisualStyleBackColor = true;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Resposta);
            this.panel1.Location = new System.Drawing.Point(33, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 100);
            this.panel1.TabIndex = 3;
            // 
            // lbl_Resposta
            // 
            this.lbl_Resposta.AutoSize = true;
            this.lbl_Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resposta.ForeColor = System.Drawing.Color.SpringGreen;
            this.lbl_Resposta.Location = new System.Drawing.Point(178, 29);
            this.lbl_Resposta.Name = "lbl_Resposta";
            this.lbl_Resposta.Size = new System.Drawing.Size(136, 63);
            this.lbl_Resposta.TabIndex = 0;
            this.lbl_Resposta.Text = "0,00";
            this.lbl_Resposta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONVERTER";
            // 
            // Frm_Conversao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 256);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Converter);
            this.Controls.Add(this.txt_Metros);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Conversao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto 4 - Converte Metros para Centímetros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Metros;
        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Resposta;
        private System.Windows.Forms.Label label2;
    }
}