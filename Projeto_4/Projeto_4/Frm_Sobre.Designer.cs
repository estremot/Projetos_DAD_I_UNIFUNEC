namespace Projeto_4
{
    partial class Frm_Sobre
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cl_Titulo = new System.Windows.Forms.ColorDialog();
            this.btn_Cor_Titulo = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btn_Fonte = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Titulo.Location = new System.Drawing.Point(138, 21);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(308, 37);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Estemote Sistemas";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(49, 76);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.ReadOnly = true;
            this.txt_Descricao.Size = new System.Drawing.Size(508, 126);
            this.txt_Descricao.TabIndex = 1;
            this.txt_Descricao.Text = "Este Sistema é elaborado para as práticas de ensino do UNIFUNEC.\r\n\r\nTODOS OS ALUN" +
    "OS DESTE CURSO SAEM COM EMPREGOS GARANTIDOS!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Ativar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Desativar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Cor_Titulo
            // 
            this.btn_Cor_Titulo.Location = new System.Drawing.Point(49, 283);
            this.btn_Cor_Titulo.Name = "btn_Cor_Titulo";
            this.btn_Cor_Titulo.Size = new System.Drawing.Size(75, 23);
            this.btn_Cor_Titulo.TabIndex = 4;
            this.btn_Cor_Titulo.Text = "Cor Titulo";
            this.btn_Cor_Titulo.UseVisualStyleBackColor = true;
            this.btn_Cor_Titulo.Click += new System.EventHandler(this.btn_Cor_Titulo_Click);
            // 
            // btn_Fonte
            // 
            this.btn_Fonte.Location = new System.Drawing.Point(130, 283);
            this.btn_Fonte.Name = "btn_Fonte";
            this.btn_Fonte.Size = new System.Drawing.Size(75, 23);
            this.btn_Fonte.TabIndex = 5;
            this.btn_Fonte.Text = "Mudar Fonte";
            this.btn_Fonte.UseVisualStyleBackColor = true;
            this.btn_Fonte.Click += new System.EventHandler(this.btn_Fonte_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.doc";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "e:\\";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Abrir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Frm_Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Fonte);
            this.Controls.Add(this.btn_Cor_Titulo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.lbl_Titulo);
            this.Name = "Frm_Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Porjeto 4 - Sobre a Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog cl_Titulo;
        private System.Windows.Forms.Button btn_Cor_Titulo;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_Fonte;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}