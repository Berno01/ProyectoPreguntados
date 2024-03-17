namespace Vista
{
    partial class frmPrincipal
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
            this.msMenuUsuario = new System.Windows.Forms.MenuStrip();
            this.btnJuego = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRank = new System.Windows.Forms.ToolStripMenuItem();
            this.top10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msMenuAdmin = new System.Windows.Forms.MenuStrip();
            this.btnGestionar = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preguntasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.msMenuAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuUsuario
            // 
            this.msMenuUsuario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnJuego,
            this.btnRank});
            this.msMenuUsuario.Location = new System.Drawing.Point(0, 24);
            this.msMenuUsuario.Name = "msMenuUsuario";
            this.msMenuUsuario.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMenuUsuario.Size = new System.Drawing.Size(685, 24);
            this.msMenuUsuario.TabIndex = 0;
            this.msMenuUsuario.Text = "menuStrip1";
            // 
            // btnJuego
            // 
            this.btnJuego.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.btnJuego.Name = "btnJuego";
            this.btnJuego.Size = new System.Drawing.Size(50, 20);
            this.btnJuego.Text = "Juego";
            this.btnJuego.Click += new System.EventHandler(this.btnJuego_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // btnRank
            // 
            this.btnRank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top10ToolStripMenuItem});
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(62, 20);
            this.btnRank.Text = "Ranking";
            // 
            // top10ToolStripMenuItem
            // 
            this.top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            this.top10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.top10ToolStripMenuItem.Text = "Top 10";
            this.top10ToolStripMenuItem.Click += new System.EventHandler(this.top10ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.picUsuario);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(189, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picUsuario
            // 
            this.picUsuario.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picUsuario.Location = new System.Drawing.Point(40, 47);
            this.picUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(92, 76);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 2;
            this.picUsuario.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(62, 15);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(80, 20);
            this.txtUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // msMenuAdmin
            // 
            this.msMenuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGestionar});
            this.msMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.msMenuAdmin.Name = "msMenuAdmin";
            this.msMenuAdmin.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMenuAdmin.Size = new System.Drawing.Size(685, 24);
            this.msMenuAdmin.TabIndex = 2;
            this.msMenuAdmin.Text = "menuStrip1";
            // 
            // btnGestionar
            // 
            this.btnGestionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.preguntasToolStripMenuItem});
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(69, 20);
            this.btnGestionar.Text = "Gestionar";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // preguntasToolStripMenuItem
            // 
            this.preguntasToolStripMenuItem.Name = "preguntasToolStripMenuItem";
            this.preguntasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preguntasToolStripMenuItem.Text = "Preguntas";
            this.preguntasToolStripMenuItem.Click += new System.EventHandler(this.preguntasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 340);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msMenuUsuario);
            this.Controls.Add(this.msMenuAdmin);
            this.MainMenuStrip = this.msMenuUsuario;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenuUsuario.ResumeLayout(false);
            this.msMenuUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.msMenuAdmin.ResumeLayout(false);
            this.msMenuAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem btnJuego;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRank;
        private System.Windows.Forms.ToolStripMenuItem top10ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip msMenuAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem btnGestionar;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preguntasToolStripMenuItem;
    }
}