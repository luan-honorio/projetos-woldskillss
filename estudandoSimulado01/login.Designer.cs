namespace estudandoSimulado01
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btncadastrese = new System.Windows.Forms.Label();
            this.btnsenhanova = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "FllowWs - Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(200, 189);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(544, 20);
            this.txtemail.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(66, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncadastrese
            // 
            this.btncadastrese.AutoSize = true;
            this.btncadastrese.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncadastrese.Location = new System.Drawing.Point(58, 379);
            this.btncadastrese.Name = "btncadastrese";
            this.btncadastrese.Size = new System.Drawing.Size(163, 31);
            this.btncadastrese.TabIndex = 6;
            this.btncadastrese.Text = "Cadastre-se";
            this.btncadastrese.Click += new System.EventHandler(this.btncadastrese_Click);
            // 
            // btnsenhanova
            // 
            this.btnsenhanova.AutoSize = true;
            this.btnsenhanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsenhanova.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsenhanova.Location = new System.Drawing.Point(58, 341);
            this.btnsenhanova.Name = "btnsenhanova";
            this.btnsenhanova.Size = new System.Drawing.Size(253, 31);
            this.btnsenhanova.TabIndex = 7;
            this.btnsenhanova.Text = "Esqueceu a senha?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(686, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "sair";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(200, 235);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(544, 20);
            this.txtsenha.TabIndex = 9;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsenhanova);
            this.Controls.Add(this.btncadastrese);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label btncadastrese;
        private System.Windows.Forms.Label btnsenhanova;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsenha;
    }
}

