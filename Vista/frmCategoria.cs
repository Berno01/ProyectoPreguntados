using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Internal.VisualStudio.PlatformUI;
using Negocio;


namespace Vista
{
    
    public partial class frmCategoria : Form
    {
        CategoriaNegocio objCateg; 
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            Listar();
        }


        public void Listar()
        {
            
            dgvCategoria.Rows.Clear();
         

            List<CategoriaNegocio> lista = CategoriaNegocio.Listar();

            for (int i = 0; i < lista.Count; i++)
            {

                objCateg = lista[i];
                object imagen = objCateg.Imagen.ToString();
                dgvCategoria.Rows.Add(objCateg.NombreCategoria.ToString(), imagen);
                dgvCategoria.Rows[i].Tag = objCateg;
            }
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objCateg = (CategoriaNegocio)dgvCategoria.CurrentRow.Tag;
      
            txtNombreCat.Text = objCateg.NombreCategoria;
            picImagen.Image = Image.FromFile(objCateg.Imagen);
            picImagen.ImageLocation = objCateg.Imagen;

        }

        private void frmCategoria_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "Formato JPG|*.jpg|Imagenes GIF|*.gif|Imagenes bitmasps|*.bmp";
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                picImagen.Image = Image.FromFile(fo.FileName);
                picImagen.ImageLocation = fo.FileName;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objCateg = new CategoriaNegocio();
            
            objCateg.NombreCategoria = txtNombreCat.Text;
            objCateg.Imagen = picImagen.ImageLocation;
            objCateg.Registrar();
            Listar();
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            switch (this.dgvCategoria.Columns[e.ColumnIndex].Name)
            {
                case "cImagen":
                    if(e.Value!=null)
                    {
                        try
                        {
                            e.Value = Image.FromFile(e.Value.ToString());
                        }
                        catch (System.IO.FileNotFoundException exc)
                        {
                            e.Value = null;
                        }
                    }
                    break;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            objCateg = (CategoriaNegocio)dgvCategoria.CurrentRow.Tag;

            objCateg.NombreCategoria = txtNombreCat.Text;
            objCateg.Imagen = picImagen.ImageLocation;
            objCateg.Modificar();
            Listar();
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            objCateg = (CategoriaNegocio)dgvCategoria.CurrentRow.Tag;

            objCateg.Borrar();
            Listar();
            picImagen.ImageLocation = "";
            
            txtNombreCat.Text = "";

            

        }
    }



}
