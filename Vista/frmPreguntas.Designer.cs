namespace Vista
{
    partial class frmPreguntas
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRespCorr = new System.Windows.Forms.RichTextBox();
            this.txtPregunta = new System.Windows.Forms.RichTextBox();
            this.txtRespInc1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRespInc2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listCateg = new System.Windows.Forms.ComboBox();
            this.listPreguntaData = new System.Windows.Forms.DataGridView();
            this.colPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listPreguntaData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pregunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Respuesta Correcta:";
            // 
            // txtRespCorr
            // 
            this.txtRespCorr.Location = new System.Drawing.Point(136, 69);
            this.txtRespCorr.Margin = new System.Windows.Forms.Padding(2);
            this.txtRespCorr.Name = "txtRespCorr";
            this.txtRespCorr.Size = new System.Drawing.Size(171, 48);
            this.txtRespCorr.TabIndex = 4;
            this.txtRespCorr.Text = "";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(136, 17);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(171, 48);
            this.txtPregunta.TabIndex = 5;
            this.txtPregunta.Text = "";
            // 
            // txtRespInc1
            // 
            this.txtRespInc1.Location = new System.Drawing.Point(136, 121);
            this.txtRespInc1.Margin = new System.Windows.Forms.Padding(2);
            this.txtRespInc1.Name = "txtRespInc1";
            this.txtRespInc1.Size = new System.Drawing.Size(171, 48);
            this.txtRespInc1.TabIndex = 7;
            this.txtRespInc1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Respuesta Incorrecta 1:";
            // 
            // txtRespInc2
            // 
            this.txtRespInc2.Location = new System.Drawing.Point(136, 173);
            this.txtRespInc2.Margin = new System.Windows.Forms.Padding(2);
            this.txtRespInc2.Name = "txtRespInc2";
            this.txtRespInc2.Size = new System.Drawing.Size(171, 48);
            this.txtRespInc2.TabIndex = 9;
            this.txtRespInc2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Respuesta Incorrecta 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Categoria";
            // 
            // listCateg
            // 
            this.listCateg.FormattingEnabled = true;
            this.listCateg.Location = new System.Drawing.Point(136, 243);
            this.listCateg.Margin = new System.Windows.Forms.Padding(2);
            this.listCateg.Name = "listCateg";
            this.listCateg.Size = new System.Drawing.Size(171, 21);
            this.listCateg.TabIndex = 11;
            this.listCateg.SelectedIndexChanged += new System.EventHandler(this.listCateg_SelectedIndexChanged);
            // 
            // listPreguntaData
            // 
            this.listPreguntaData.AllowUserToAddRows = false;
            this.listPreguntaData.AllowUserToDeleteRows = false;
            this.listPreguntaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPreguntaData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPregunta});
            this.listPreguntaData.Location = new System.Drawing.Point(321, 20);
            this.listPreguntaData.Margin = new System.Windows.Forms.Padding(2);
            this.listPreguntaData.Name = "listPreguntaData";
            this.listPreguntaData.ReadOnly = true;
            this.listPreguntaData.RowHeadersWidth = 51;
            this.listPreguntaData.RowTemplate.Height = 24;
            this.listPreguntaData.Size = new System.Drawing.Size(440, 243);
            this.listPreguntaData.TabIndex = 15;
            this.listPreguntaData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listPreguntaData_CellClick);
            // 
            // colPregunta
            // 
            this.colPregunta.HeaderText = "Pregunta";
            this.colPregunta.MinimumWidth = 6;
            this.colPregunta.Name = "colPregunta";
            this.colPregunta.ReadOnly = true;
            this.colPregunta.Width = 400;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(577, 280);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 22);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(503, 280);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(61, 22);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(437, 280);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(61, 22);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 311);
            this.Controls.Add(this.listPreguntaData);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.listCateg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRespInc2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRespInc1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.txtRespCorr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPreguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPreguntas";
            this.Load += new System.EventHandler(this.frmPreguntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPreguntaData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtRespCorr;
        private System.Windows.Forms.RichTextBox txtPregunta;
        private System.Windows.Forms.RichTextBox txtRespInc1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtRespInc2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listCateg;
        private System.Windows.Forms.DataGridView listPreguntaData;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPregunta;
    }
}