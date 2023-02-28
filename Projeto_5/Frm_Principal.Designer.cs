namespace Projeto_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.grb_Sexo = new System.Windows.Forms.GroupBox();
            this.rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.grb_Exames = new System.Windows.Forms.GroupBox();
            this.chb_Ortopedico = new System.Windows.Forms.CheckBox();
            this.chb_Mamografia = new System.Windows.Forms.CheckBox();
            this.chb_Sangue = new System.Windows.Forms.CheckBox();
            this.chb_Prostata = new System.Windows.Forms.CheckBox();
            this.chb_gravidez = new System.Windows.Forms.CheckBox();
            this.chb_Coracao = new System.Windows.Forms.CheckBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.grb_Sexo.SuspendLayout();
            this.grb_Exames.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 40);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(314, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // grb_Sexo
            // 
            this.grb_Sexo.Controls.Add(this.rdb_Masculino);
            this.grb_Sexo.Controls.Add(this.rdb_Feminino);
            this.grb_Sexo.Location = new System.Drawing.Point(12, 66);
            this.grb_Sexo.Name = "grb_Sexo";
            this.grb_Sexo.Size = new System.Drawing.Size(134, 100);
            this.grb_Sexo.TabIndex = 2;
            this.grb_Sexo.TabStop = false;
            this.grb_Sexo.Text = "Sexo";
            // 
            // rdb_Masculino
            // 
            this.rdb_Masculino.AutoSize = true;
            this.rdb_Masculino.Location = new System.Drawing.Point(6, 62);
            this.rdb_Masculino.Name = "rdb_Masculino";
            this.rdb_Masculino.Size = new System.Drawing.Size(73, 17);
            this.rdb_Masculino.TabIndex = 1;
            this.rdb_Masculino.Text = "Masculino";
            this.rdb_Masculino.UseVisualStyleBackColor = true;
            this.rdb_Masculino.Click += new System.EventHandler(this.rdb_Masculino_Click);
            // 
            // rdb_Feminino
            // 
            this.rdb_Feminino.AutoSize = true;
            this.rdb_Feminino.Checked = true;
            this.rdb_Feminino.Location = new System.Drawing.Point(6, 28);
            this.rdb_Feminino.Name = "rdb_Feminino";
            this.rdb_Feminino.Size = new System.Drawing.Size(67, 17);
            this.rdb_Feminino.TabIndex = 0;
            this.rdb_Feminino.TabStop = true;
            this.rdb_Feminino.Text = "Feminino";
            this.rdb_Feminino.UseVisualStyleBackColor = true;
            this.rdb_Feminino.Click += new System.EventHandler(this.rdb_Feminino_Click);
            // 
            // grb_Exames
            // 
            this.grb_Exames.Controls.Add(this.chb_Ortopedico);
            this.grb_Exames.Controls.Add(this.chb_Mamografia);
            this.grb_Exames.Controls.Add(this.chb_Sangue);
            this.grb_Exames.Controls.Add(this.chb_Prostata);
            this.grb_Exames.Controls.Add(this.chb_gravidez);
            this.grb_Exames.Controls.Add(this.chb_Coracao);
            this.grb_Exames.Location = new System.Drawing.Point(152, 66);
            this.grb_Exames.Name = "grb_Exames";
            this.grb_Exames.Size = new System.Drawing.Size(288, 100);
            this.grb_Exames.TabIndex = 3;
            this.grb_Exames.TabStop = false;
            this.grb_Exames.Text = "Exames";
            // 
            // chb_Ortopedico
            // 
            this.chb_Ortopedico.AutoSize = true;
            this.chb_Ortopedico.Location = new System.Drawing.Point(178, 62);
            this.chb_Ortopedico.Name = "chb_Ortopedico";
            this.chb_Ortopedico.Size = new System.Drawing.Size(78, 17);
            this.chb_Ortopedico.TabIndex = 5;
            this.chb_Ortopedico.Text = "Ortopédico";
            this.chb_Ortopedico.UseVisualStyleBackColor = true;
            this.chb_Ortopedico.Click += new System.EventHandler(this.chb_Ortopedico_Click);
            // 
            // chb_Mamografia
            // 
            this.chb_Mamografia.AutoSize = true;
            this.chb_Mamografia.Location = new System.Drawing.Point(178, 29);
            this.chb_Mamografia.Name = "chb_Mamografia";
            this.chb_Mamografia.Size = new System.Drawing.Size(81, 17);
            this.chb_Mamografia.TabIndex = 4;
            this.chb_Mamografia.Text = "Mamografia";
            this.chb_Mamografia.UseVisualStyleBackColor = true;
            this.chb_Mamografia.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            this.chb_Mamografia.Click += new System.EventHandler(this.chb_Mamografia_Click);
            // 
            // chb_Sangue
            // 
            this.chb_Sangue.AutoSize = true;
            this.chb_Sangue.Location = new System.Drawing.Point(92, 62);
            this.chb_Sangue.Name = "chb_Sangue";
            this.chb_Sangue.Size = new System.Drawing.Size(63, 17);
            this.chb_Sangue.TabIndex = 3;
            this.chb_Sangue.Text = "Sangue";
            this.chb_Sangue.UseVisualStyleBackColor = true;
            this.chb_Sangue.Click += new System.EventHandler(this.chb_Sangue_Click);
            // 
            // chb_Prostata
            // 
            this.chb_Prostata.AutoSize = true;
            this.chb_Prostata.Enabled = false;
            this.chb_Prostata.Location = new System.Drawing.Point(92, 29);
            this.chb_Prostata.Name = "chb_Prostata";
            this.chb_Prostata.Size = new System.Drawing.Size(65, 17);
            this.chb_Prostata.TabIndex = 2;
            this.chb_Prostata.Text = "Próstata";
            this.chb_Prostata.UseVisualStyleBackColor = true;
            this.chb_Prostata.Click += new System.EventHandler(this.chb_Prostata_Click);
            // 
            // chb_gravidez
            // 
            this.chb_gravidez.AutoSize = true;
            this.chb_gravidez.Location = new System.Drawing.Point(6, 62);
            this.chb_gravidez.Name = "chb_gravidez";
            this.chb_gravidez.Size = new System.Drawing.Size(68, 17);
            this.chb_gravidez.TabIndex = 1;
            this.chb_gravidez.Text = "Gravidez";
            this.chb_gravidez.UseVisualStyleBackColor = true;
            this.chb_gravidez.Click += new System.EventHandler(this.chb_gravidez_Click);
            // 
            // chb_Coracao
            // 
            this.chb_Coracao.AutoSize = true;
            this.chb_Coracao.Location = new System.Drawing.Point(6, 28);
            this.chb_Coracao.Name = "chb_Coracao";
            this.chb_Coracao.Size = new System.Drawing.Size(66, 17);
            this.chb_Coracao.TabIndex = 0;
            this.chb_Coracao.Text = "Coração";
            this.chb_Coracao.UseVisualStyleBackColor = true;
            this.chb_Coracao.Click += new System.EventHandler(this.chb_Coracao_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(12, 183);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(84, 37);
            this.lbl_Total.TabIndex = 4;
            this.lbl_Total.Text = "0,00";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 238);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.grb_Exames);
            this.Controls.Add(this.grb_Sexo);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Principal";
            this.Text = "Clínica UNIFUNEC - 2023";
            this.grb_Sexo.ResumeLayout(false);
            this.grb_Sexo.PerformLayout();
            this.grb_Exames.ResumeLayout(false);
            this.grb_Exames.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.GroupBox grb_Sexo;
        private System.Windows.Forms.RadioButton rdb_Masculino;
        private System.Windows.Forms.RadioButton rdb_Feminino;
        private System.Windows.Forms.GroupBox grb_Exames;
        private System.Windows.Forms.CheckBox chb_Mamografia;
        private System.Windows.Forms.CheckBox chb_Sangue;
        private System.Windows.Forms.CheckBox chb_Prostata;
        private System.Windows.Forms.CheckBox chb_gravidez;
        private System.Windows.Forms.CheckBox chb_Coracao;
        private System.Windows.Forms.CheckBox chb_Ortopedico;
        private System.Windows.Forms.Label lbl_Total;
    }
}

