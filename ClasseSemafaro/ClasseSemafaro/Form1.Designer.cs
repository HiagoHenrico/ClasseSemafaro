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
            this.btnSem1Vermelho = new System.Windows.Forms.Button();
            this.btnSemAmarelo = new System.Windows.Forms.Button();
            this.btnSemVerde = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rua 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rua 2";
            // 
            // btnSem1Vermelho
            // 
            this.btnSem1Vermelho.Location = new System.Drawing.Point(377, 288);
            this.btnSem1Vermelho.Name = "btnSem1Vermelho";
            this.btnSem1Vermelho.Size = new System.Drawing.Size(75, 23);
            this.btnSem1Vermelho.TabIndex = 4;
            this.btnSem1Vermelho.Text = "Vermelho";
            this.btnSem1Vermelho.UseVisualStyleBackColor = true;
            this.btnSem1Vermelho.Click += new System.EventHandler(this.btnSem1Vermelho_Click);
            // 
            // btnSemAmarelo
            // 
            this.btnSemAmarelo.Location = new System.Drawing.Point(377, 331);
            this.btnSemAmarelo.Name = "btnSemAmarelo";
            this.btnSemAmarelo.Size = new System.Drawing.Size(74, 25);
            this.btnSemAmarelo.TabIndex = 5;
            this.btnSemAmarelo.Text = "Amarelo";
            this.btnSemAmarelo.UseVisualStyleBackColor = true;
            // 
            // btnSemVerde
            // 
            this.btnSemVerde.Location = new System.Drawing.Point(376, 373);
            this.btnSemVerde.Name = "btnSemVerde";
            this.btnSemVerde.Size = new System.Drawing.Size(75, 23);
            this.btnSemVerde.TabIndex = 6;
            this.btnSemVerde.Text = "Verde";
            this.btnSemVerde.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSemVerde);
            this.Controls.Add(this.btnSemAmarelo);
            this.Controls.Add(this.btnSem1Vermelho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btnSem1Vermelho;
        private System.Windows.Forms.Button btnSemAmarelo;
        private System.Windows.Forms.Button btnSemVerde;
    }
}

