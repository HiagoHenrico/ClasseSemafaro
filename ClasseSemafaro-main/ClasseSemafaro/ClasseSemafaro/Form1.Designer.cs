namespace ClasseSemafaro
{
    partial class Form1
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstBinario = new System.Windows.Forms.TextBox();
            this.chkVermelho1 = new System.Windows.Forms.CheckBox();
            this.chkAmarelo1 = new System.Windows.Forms.CheckBox();
            this.chkVerde1 = new System.Windows.Forms.CheckBox();
            this.chkVermelho2 = new System.Windows.Forms.CheckBox();
            this.chkAmarelo2 = new System.Windows.Forms.CheckBox();
            this.chkVerde2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstHexadecimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstDecimal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClasseSemafaro.Properties.Resources.semafaroApagado1;
            this.pictureBox2.Location = new System.Drawing.Point(137, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClasseSemafaro.Properties.Resources.semafaroApagado1;
            this.pictureBox1.Location = new System.Drawing.Point(567, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Semáfaro 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semáfaro 2";
            // 
            // txtEstBinario
            // 
            this.txtEstBinario.Location = new System.Drawing.Point(293, 343);
            this.txtEstBinario.Name = "txtEstBinario";
            this.txtEstBinario.Size = new System.Drawing.Size(180, 20);
            this.txtEstBinario.TabIndex = 7;
            // 
            // chkVermelho1
            // 
            this.chkVermelho1.AutoSize = true;
            this.chkVermelho1.Location = new System.Drawing.Point(272, 74);
            this.chkVermelho1.Name = "chkVermelho1";
            this.chkVermelho1.Size = new System.Drawing.Size(70, 17);
            this.chkVermelho1.TabIndex = 8;
            this.chkVermelho1.Text = "Vermelho";
            this.chkVermelho1.UseVisualStyleBackColor = true;
            this.chkVermelho1.CheckedChanged += new System.EventHandler(this.chkVermelho1_CheckedChanged);
            // 
            // chkAmarelo1
            // 
            this.chkAmarelo1.AutoSize = true;
            this.chkAmarelo1.Location = new System.Drawing.Point(272, 138);
            this.chkAmarelo1.Name = "chkAmarelo1";
            this.chkAmarelo1.Size = new System.Drawing.Size(64, 17);
            this.chkAmarelo1.TabIndex = 9;
            this.chkAmarelo1.Text = "Amarelo";
            this.chkAmarelo1.UseVisualStyleBackColor = true;
            this.chkAmarelo1.CheckedChanged += new System.EventHandler(this.chkAmarelo1_CheckedChanged);
            // 
            // chkVerde1
            // 
            this.chkVerde1.AutoSize = true;
            this.chkVerde1.Location = new System.Drawing.Point(272, 205);
            this.chkVerde1.Name = "chkVerde1";
            this.chkVerde1.Size = new System.Drawing.Size(54, 17);
            this.chkVerde1.TabIndex = 10;
            this.chkVerde1.Text = "Verde";
            this.chkVerde1.UseVisualStyleBackColor = true;
            this.chkVerde1.CheckedChanged += new System.EventHandler(this.chkVerde1_CheckedChanged);
            // 
            // chkVermelho2
            // 
            this.chkVermelho2.AutoSize = true;
            this.chkVermelho2.Location = new System.Drawing.Point(469, 74);
            this.chkVermelho2.Name = "chkVermelho2";
            this.chkVermelho2.Size = new System.Drawing.Size(70, 17);
            this.chkVermelho2.TabIndex = 11;
            this.chkVermelho2.Text = "Vermelho";
            this.chkVermelho2.UseVisualStyleBackColor = true;
            this.chkVermelho2.CheckedChanged += new System.EventHandler(this.chkVermelho2_CheckedChanged);
            // 
            // chkAmarelo2
            // 
            this.chkAmarelo2.AutoSize = true;
            this.chkAmarelo2.Location = new System.Drawing.Point(469, 138);
            this.chkAmarelo2.Name = "chkAmarelo2";
            this.chkAmarelo2.Size = new System.Drawing.Size(64, 17);
            this.chkAmarelo2.TabIndex = 12;
            this.chkAmarelo2.Text = "Amarelo";
            this.chkAmarelo2.UseVisualStyleBackColor = true;
            this.chkAmarelo2.CheckedChanged += new System.EventHandler(this.chkAmarelo2_CheckedChanged);
            // 
            // chkVerde2
            // 
            this.chkVerde2.AutoSize = true;
            this.chkVerde2.Location = new System.Drawing.Point(469, 205);
            this.chkVerde2.Name = "chkVerde2";
            this.chkVerde2.Size = new System.Drawing.Size(54, 17);
            this.chkVerde2.TabIndex = 13;
            this.chkVerde2.Text = "Verde";
            this.chkVerde2.UseVisualStyleBackColor = true;
            this.chkVerde2.CheckedChanged += new System.EventHandler(this.chkVerde2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "BINÁRIO";
            // 
            // txtEstHexadecimal
            // 
            this.txtEstHexadecimal.Location = new System.Drawing.Point(479, 343);
            this.txtEstHexadecimal.Name = "txtEstHexadecimal";
            this.txtEstHexadecimal.Size = new System.Drawing.Size(146, 20);
            this.txtEstHexadecimal.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "HEXADECIMAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DECIMAL";
            // 
            // txtEstDecimal
            // 
            this.txtEstDecimal.Location = new System.Drawing.Point(163, 343);
            this.txtEstDecimal.Name = "txtEstDecimal";
            this.txtEstDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtEstDecimal.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstDecimal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstHexadecimal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkVerde2);
            this.Controls.Add(this.chkAmarelo2);
            this.Controls.Add(this.chkVermelho2);
            this.Controls.Add(this.chkVerde1);
            this.Controls.Add(this.chkAmarelo1);
            this.Controls.Add(this.chkVermelho1);
            this.Controls.Add(this.txtEstBinario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstBinario;
        private System.Windows.Forms.CheckBox chkVermelho1;
        private System.Windows.Forms.CheckBox chkAmarelo1;
        private System.Windows.Forms.CheckBox chkVerde1;
        private System.Windows.Forms.CheckBox chkVermelho2;
        private System.Windows.Forms.CheckBox chkAmarelo2;
        private System.Windows.Forms.CheckBox chkVerde2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstHexadecimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstDecimal;
    }
}

