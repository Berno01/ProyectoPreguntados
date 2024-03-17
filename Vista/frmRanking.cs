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
    public partial class frmRanking : Form
    {
        RegistroNegocio objUser;

        public frmRanking()
        {
            InitializeComponent();
        }

        private void frmRanking_Load(object sender, EventArgs e)
        {
            ListarRank();
        }

        public void ListarRank()
        {
            dgvRank.Rows.Clear();
            List<RegistroNegocio> lista = RegistroNegocio.ListarRank();
            for (int i = 0; i < lista.Count; i++)
            {
                objUser = lista[i];
                object imagen = objUser.Foto.ToString();
                dgvRank.Rows.Add(objUser.Ci, objUser.NombreCompl, objUser.NomGenero, imagen, objUser.Puntaje.ToString());
                dgvRank.Rows[i].Tag = dgvRank;
            }
        }



        private void dgvRank_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            switch (this.dgvRank.Columns[e.ColumnIndex].Name)
            {
                case "cImagen":
                    if (e.Value != null)
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


    }
}
