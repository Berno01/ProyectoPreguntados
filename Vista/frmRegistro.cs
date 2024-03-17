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
    public partial class frmRegistro : Form
    {
        RegistroNegocio objReg;
        GeneroNegocio objGenero;
        PaisNegocio objPais;

        public frmRegistro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objReg = new RegistroNegocio();
            objGenero = (GeneroNegocio)cbGenero.SelectedItem;
            objPais = (PaisNegocio)cbPais.SelectedItem;


            objReg.Ci = txtCI.Text;
            objReg.NombreCompl = txtNombreComp.Text;
            objReg.IdGenero = objGenero.IdGenero;
            objReg.IdPais = objPais.IdPais;
            objReg.Usuario = txtUsuario.Text;
            objReg.Contra = txtContra.Text;
            objReg.Foto = picFoto.ImageLocation;
            objReg.Registrar();
            limpiar();          


        }

        public void listarGenero()
        {
            cbGenero.Items.Clear();
            foreach(var item in GeneroNegocio.Listar())
            {
                cbGenero.Items.Add(item);   
            }
            cbGenero.DisplayMember = "NombreGenero";

        }

        public void listarPais()
        {
            cbPais.Items.Clear();
            foreach (var item in PaisNegocio.Listar())
            {
                cbPais.Items.Add(item);
            }
            cbPais.DisplayMember = "NombrePais";

        }

        public void limpiar()
        {
            txtCI.Text = "";
            txtNombreComp.Text = "";
            cbGenero.Text = "";
            cbPais.Text = "";
            txtUsuario.Text = "";
            txtContra.Text = "";
            picFoto.ImageLocation = "";

        }



        private void frmRegistro_Load(object sender, EventArgs e)
        {
            listarGenero();
            listarPais();

        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            objGenero = (GeneroNegocio)cbGenero.SelectedItem;

        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPais = (PaisNegocio)cbPais.SelectedItem;

        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "Formato JPG|*.jpg|Imagenes GIF|*.gif|Imagenes bitmasps|*.bmp";
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(fo.FileName);
                picFoto.ImageLocation = fo.FileName;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
