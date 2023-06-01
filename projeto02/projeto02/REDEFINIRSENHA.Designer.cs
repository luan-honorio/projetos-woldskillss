namespace testeprova01
{
    partial class REDEFINIRSENHA
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
            this.alterarsenha = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnovasenha = new System.Windows.Forms.TextBox();
            this.txtconfirma = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de nascimento";
            // 
            // alterarsenha
            // 
            this.alterarsenha.Location = new System.Drawing.Point(285, 182);
            this.alterarsenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.alterarsenha.Name = "alterarsenha";
            this.alterarsenha.Size = new System.Drawing.Size(121, 33);
            this.alterarsenha.TabIndex = 1;
            this.alterarsenha.Text = "Alterar senha";
            this.alterarsenha.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(203, 27);
            this.data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(203, 22);
            this.data.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "time favorito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "nova senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "confirmar senha";
            // 
            // txtnovasenha
            // 
            this.txtnovasenha.Location = new System.Drawing.Point(203, 107);
            this.txtnovasenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnovasenha.Name = "txtnovasenha";
            this.txtnovasenha.Size = new System.Drawing.Size(203, 22);
            this.txtnovasenha.TabIndex = 6;
            // 
            // txtconfirma
            // 
            this.txtconfirma.Location = new System.Drawing.Point(203, 150);
            this.txtconfirma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtconfirma.Name = "txtconfirma";
            this.txtconfirma.Size = new System.Drawing.Size(203, 22);
            this.txtconfirma.TabIndex = 7;
            // 
            // time
            // 
            this.time.FormattingEnabled = true;
            this.time.Items.AddRange(new object[] {
            "Alemanha",
            "Argentina",
            "Belgica",
            "Brasil",
            "Camarões",
            "Chile",
            "Colombia",
            "Equador",
            "Espanha",
            "França",
            "Holanda",
            "Inglaterra",
            "Itália",
            "Portugal",
            "Rússia",
            "Uruguai"});
            this.time.Location = new System.Drawing.Point(203, 73);
            this.time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(203, 24);
            this.time.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(265, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Voltar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // REDEFINIRSENHA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 279);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time);
            this.Controls.Add(this.txtconfirma);
            this.Controls.Add(this.txtnovasenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.alterarsenha);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "REDEFINIRSENHA";
            this.Text = "REDEFINIRSENHA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button alterarsenha;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnovasenha;
        private System.Windows.Forms.TextBox txtconfirma;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.Label label5;
    }
}