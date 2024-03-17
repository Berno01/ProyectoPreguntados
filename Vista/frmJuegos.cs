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

    /*JuegoNegocio objJuego;*/
    public partial class frmJuegos : Form
    {
        RegistroNegocio userAct = new RegistroNegocio();
        PreguntasNegocio objPreg = new PreguntasNegocio();
        JuegoNegocio objJueg = new JuegoNegocio();
        CategoriaNegocio objCategoria = new CategoriaNegocio();
        double puntaje;
        int numPreg;

        public frmJuegos(RegistroNegocio user, double puntaje, int numPreg)
        {
            InitializeComponent();
            userAct = user;
            this.puntaje = puntaje;
            this.numPreg = numPreg;
            txtPartidas.Text = numPreg.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmJuegos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            List<PreguntasNegocio> lista = PreguntasNegocio.ListarAle();
            for (int i = 0; i < lista.Count; i++)
            {

                objPreg = lista[i];

                picCategoria.ImageLocation = objPreg.CatDatos.Imagen.ToString();
                txtPregunta.Text = objPreg.Pregunta;
                txtNombreCat.Text = objPreg.CatDatos.NombreCategoria;

                Random r = new Random();

                //Genera un numero entre 10 y 100 (101 no se incluye)
                int alea = r.Next(0, 101);
                if (alea<35)
                {
                    btnResp2.Text = objPreg.RespuestaCorrecta;
                    btnResp3.Text = objPreg.RespuestaIncorrecta1;
                    btnResp4.Text = objPreg.RespuestaIncorrecta2;
                }
                else if(alea>35 & alea<70) 
                {
                    btnResp2.Text = objPreg.RespuestaIncorrecta2;
                    btnResp3.Text = objPreg.RespuestaIncorrecta1;
                    btnResp4.Text = objPreg.RespuestaCorrecta;

                } else
                {
                    btnResp2.Text = objPreg.RespuestaIncorrecta2;
                    btnResp3.Text = objPreg.RespuestaCorrecta;
                    btnResp4.Text = objPreg.RespuestaIncorrecta1;
                }

            }
        }

        public void RegistrarJuego()
        {
            objJueg.IdCat = objPreg.IdCat;
            objJueg.Ci = userAct.Ci;
            objJueg.Puntaje = puntaje;
            objJueg.Registrar();
        }



        private void btnResp2_Click(object sender, EventArgs e)
        {
            
            numPreg = numPreg + 1;
            if (btnResp2.Text == objPreg.RespuestaCorrecta)
            {
                puntaje = puntaje + 20;

            }
            if (numPreg == 6)
            {
                RegistrarJuego();
                MessageBox.Show("Puntaje Total: "+puntaje);
                this.Close();
            }
            else
            {
                frmJuegos FrmJuegos = new frmJuegos(userAct, puntaje, numPreg);
                FrmJuegos.ShowDialog();
                this.Close();
            }

            

            
        }

        private void btnResp3_Click(object sender, EventArgs e)
        {
            
            numPreg = numPreg + 1;
            if (btnResp3.Text == objPreg.RespuestaCorrecta)
            {
                puntaje = puntaje + 20;

            }

            if (numPreg == 6)
            {
                RegistrarJuego();
                MessageBox.Show("Puntaje Total: " + puntaje);
                this.Close();
            }
            else
            {
                frmJuegos FrmJuegos = new frmJuegos(userAct, puntaje, numPreg);
                FrmJuegos.ShowDialog();
                this.Close();
            }

            

        }


        private void btnResp4_Click(object sender, EventArgs e)
        {
            numPreg = numPreg + 1;
            if (btnResp4.Text == objPreg.RespuestaCorrecta)
            {
                puntaje = puntaje + 20;

            }
            
            if (numPreg == 6)
            {
                RegistrarJuego();
                MessageBox.Show("Puntaje Total: " + puntaje);
                this.Close();
            }
            else
            {
                frmJuegos FrmJuegos = new frmJuegos(userAct, puntaje, numPreg);
                FrmJuegos.ShowDialog();
                this.Close();

            }

            


        }

        private void picCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
