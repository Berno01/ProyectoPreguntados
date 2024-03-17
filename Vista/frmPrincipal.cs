using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmPrincipal : Form
    {
        RegistroNegocio userAct = new RegistroNegocio();
        public frmPrincipal(RegistroNegocio user)
        {
            InitializeComponent();
     
            userAct = user;
            string usuario = user.Usuario;
            txtUser.Text = usuario;
            picUsuario.ImageLocation = user.Foto;
            if(user.IdRol==2)
            {
                btnGestionar.Visible = false;
            }
            else
            {
                btnRank.Visible = false;
                btnJuego.Visible = false;
            }
            

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria FrmCategoria = new frmCategoria();
            FrmCategoria.ShowDialog();
        }

        private void preguntasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreguntas FrmPreguntas = new frmPreguntas();
            FrmPreguntas.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJuegos FrmJuegos = new frmJuegos(userAct, 0, 1);
            FrmJuegos.ShowDialog();
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRanking FrmRanking = new frmRanking();
            FrmRanking.ShowDialog();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
