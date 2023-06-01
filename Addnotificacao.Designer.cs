namespace testeprova01
{
    partial class Addnotificacao
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
            this.btnsalvar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grau = new System.Windows.Forms.ComboBox();
            this.titulo = new System.Windows.Forms.TextBox();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalvar.Location = new System.Drawing.Point(222, 239);
            this.btnsalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(56, 19);
            this.btnsalvar.TabIndex = 1;
            this.btnsalvar.Text = "salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(400, 91);
            this.data.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(78, 20);
            this.data.TabIndex = 2;
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
            this.time.Location = new System.Drawing.Point(118, 180);
            this.time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(160, 21);
            this.time.TabIndex = 3;
            this.time.Text = "Nenhum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time da notificaçao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grau de importancio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data da notificaçao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hora da notificação";
            // 
            // grau
            // 
            this.grau.FormattingEnabled = true;
            this.grau.Items.AddRange(new object[] {
            "urgente",
            "padão"});
            this.grau.Location = new System.Drawing.Point(124, 214);
            this.grau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grau.Name = "grau";
            this.grau.Size = new System.Drawing.Size(151, 21);
            this.grau.TabIndex = 9;
            this.grau.Text = "Padrão";
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(74, 63);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(204, 20);
            this.titulo.TabIndex = 10;
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(74, 89);
            this.descricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descricao.Multiline = true;
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(201, 57);
            this.descricao.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adicionar Notiifcaçao";
            // 
            // hora
            // 
            this.hora.Location = new System.Drawing.Point(400, 129);
            this.hora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hora.Mask = "00:00";
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(76, 20);
            this.hora.TabIndex = 13;
            // 
            // Addnotificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 296);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.grau);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Addnotificacao";
            this.Text = "Addnotificacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.ComboBox time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox grau;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox hora;
    }
}