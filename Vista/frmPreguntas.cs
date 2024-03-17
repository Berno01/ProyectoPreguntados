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
    public partial class frmPreguntas : Form
    {
        PreguntasNegocio objPreguntas;
        CategoriaNegocio objCat;
        public frmPreguntas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Clicl(object sender, EventArgs e)
        {
            objPreguntas = new PreguntasNegocio();
            objPreguntas.IdCat = listCateg.Text; 
            objPreguntas.Pregunta = txtPregunta.Text;
            objPreguntas.RespuestaCorrecta = txtRespCorr.Text;
            objPreguntas.RespuestaIncorrecta1 = txtRespInc1.Text;
            objPreguntas.RespuestaIncorrecta2 = txtRespInc2.Text;
            Listar();

        }

        public void Listar()
        {
            listPreguntaData.Rows.Clear();
            List<PreguntasNegocio> lista = PreguntasNegocio.Listar();
            for (int i=0; i < lista.Count;i++)
            {
                objPreguntas = lista[i];

                listPreguntaData.Rows.Add(objPreguntas.Pregunta.ToString());
                listPreguntaData.Rows[i].Tag = objPreguntas;
            }
        }


        public void ListarCat()
        {
            listCateg.Items.Clear();
            foreach(var item in CategoriaNegocio.Listar())
            {
                listCateg.Items.Add(item);
            }
            listCateg.DisplayMember = "NombreCategoria";
        }

        

        private void listPreguntaData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objPreguntas = (PreguntasNegocio)listPreguntaData.CurrentRow.Tag;
            
            txtPregunta.Text = objPreguntas.Pregunta.ToString();
            txtRespCorr.Text = objPreguntas.RespuestaCorrecta.ToString();
            txtRespInc1.Text = objPreguntas.RespuestaIncorrecta1.ToString();
            txtRespInc2.Text = objPreguntas.RespuestaIncorrecta2.ToString();
            listCateg.Text = objPreguntas.CatDatos.NombreCategoria;
            /*objCat = (CategoriaNegocio)listCateg.SelectedItem;*/
        }


        private void frmPreguntas_Load(object sender, EventArgs e)
        {
            Listar();
            ListarCat();
        }

        private void listCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            objCat = (CategoriaNegocio)listCateg.SelectedItem;

            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objPreguntas = new PreguntasNegocio();
            objCat = (CategoriaNegocio)listCateg.SelectedItem;
            objPreguntas.IdCat = objCat.IdCategoria.ToString();
            objPreguntas.Pregunta = txtPregunta.Text;
            objPreguntas.RespuestaCorrecta = txtRespCorr.Text;
            objPreguntas.RespuestaIncorrecta1 = txtRespInc1.Text;
            objPreguntas.RespuestaIncorrecta2 = txtRespInc2.Text;
            objPreguntas.Registrar();
            Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objPreguntas = (PreguntasNegocio)listPreguntaData.CurrentRow.Tag;
            
            objCat = (CategoriaNegocio)listCateg.SelectedItem;
            objPreguntas.IdCat = objCat.IdCategoria.ToString();
            objPreguntas.Pregunta = txtPregunta.Text;
            objPreguntas.RespuestaCorrecta = txtRespCorr.Text;
            objPreguntas.RespuestaIncorrecta1 = txtRespInc1.Text;
            objPreguntas.RespuestaIncorrecta2 = txtRespInc2.Text;
            objPreguntas.Modificar();
            Listar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            objPreguntas = (PreguntasNegocio)listPreguntaData.CurrentRow.Tag;
            objPreguntas.Eliminar();
            txtPregunta.Text = "";
            txtRespCorr.Text = "";
            txtRespInc1.Text = "";
            txtRespInc2.Text = "";
            listCateg.Text = "";
            Listar();
        }
    }
}
