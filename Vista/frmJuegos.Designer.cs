namespace Vista
{
    partial class frmJuegos
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
            this.picCategoria = new System.Windows.Forms.PictureBox();
            this.txtNombreCat = new System.Windows.Forms.Label();
            this.txtPartidas = new System.Windows.Forms.Label();
            this.btnResp2 = new System.Windows.Forms.Button();
            this.btnResp3 = new System.Windows.Forms.Button();
            this.btnResp4 = new System.Windows.Forms.Button();
            this.txtPregunta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // picCategoria
            // 
            this.picCategoria.BackColor = System.Drawing.Color.Silver;
            this.picCategoria.Location = new System.Drawing.Point(94, 98);
            this.picCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCategoria.Name = "picCategoria";
            this.picCategoria.Size = new System.Drawing.Size(112, 92);
            this.picCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCategoria.TabIndex = 16;
            this.picCategoria.TabStop = false;
            this.picCategoria.Click += new System.EventHandler(this.picCategoria_Click);
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.AutoSize = true;
            this.txtNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCat.Location = new System.Drawing.Point(117, 9);
            this.txtNombreCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(49, 24);
            this.txtNombreCat.TabIndex = 15;
            this.txtNombreCat.Text = "Hola";
            // 
            // txtPartidas
            // 
            this.txtPartidas.AutoSize = true;
            this.txtPartidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartidas.Location = new System.Drawing.Point(253, 117);
            this.txtPartidas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(35, 24);
            this.txtPartidas.TabIndex = 24;
            this.txtPartidas.Text = "1/5";
            // 
            // btnResp2
            // 
            this.btnResp2.Location = new System.Drawing.Point(22, 213);
            this.btnResp2.Name = "btnResp2";
            this.btnResp2.Size = new System.Drawing.Size(265, 34);
            this.btnResp2.TabIndex = 26;
            this.btnResp2.UseVisualStyleBackColor = true;
            this.btnResp2.Click += new System.EventHandler(this.btnResp2_Click);
            // 
            // btnResp3
            // 
            this.btnResp3.Location = new System.Drawing.Point(22, 272);
            this.btnResp3.Name = "btnResp3";
            this.btnResp3.Size = new System.Drawing.Size(265, 34);
            this.btnResp3.TabIndex = 27;
            this.btnResp3.UseVisualStyleBackColor = true;
            this.btnResp3.Click += new System.EventHandler(this.btnResp3_Click);
            // 
            // btnResp4
            // 
            this.btnResp4.Location = new System.Drawing.Point(22, 329);
            this.btnResp4.Name = "btnResp4";
            this.btnResp4.Size = new System.Drawing.Size(265, 34);
            this.btnResp4.TabIndex = 28;
            this.btnResp4.UseVisualStyleBackColor = true;
            this.btnResp4.Click += new System.EventHandler(this.btnResp4_Click);
            // 
            // txtPregunta
            // 
            this.txtPregunta.AutoSize = true;
            this.txtPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(18, 42);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(104, 20);
            this.txtPregunta.TabIndex = 29;
            this.txtPregunta.Text = "¿Quien eres?";
            this.txtPregunta.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 394);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.btnResp4);
            this.Controls.Add(this.btnResp3);
            this.Controls.Add(this.btnResp2);
            this.Controls.Add(this.txtPartidas);
            this.Controls.Add(this.picCategoria);
            this.Controls.Add(this.txtNombreCat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmJuegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJuegos";
            this.Load += new System.EventHandler(this.frmJuegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCategoria;
        private System.Windows.Forms.Label txtNombreCat;
        private System.Windows.Forms.Label txtPartidas;
        private System.Windows.Forms.Button btnResp2;
        private System.Windows.Forms.Button btnResp3;
        private System.Windows.Forms.Button btnResp4;
        private System.Windows.Forms.Label txtPregunta;
    }
}