using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using static System.Net.Mime.MediaTypeNames;

namespace Vista
{
    public partial class frmIngreso : Form
    {

        
        RegistroNegocio objReg;

        public frmIngreso()
        {
            InitializeComponent();
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistro FrmRegistro = new frmRegistro();    
            FrmRegistro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            objReg = new RegistroNegocio();
            verificar();
            
        }


        public void verificar()
        {
            string ver = "";
            
            foreach (var item in RegistroNegocio.Listar())
            {
                if(item.Usuario==txtUsuario.Text & item.Contra==txtContra.Text)
                {
                    ver = "si";
                    objReg = item;
                    break;
                }
                else
                {
                    ver = "no";
                    
                }
            }
            if(ver == "si")
            {
                frmPrincipal FrmPrincipal = new frmPrincipal(objReg);
                FrmPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contra incorrecta");
            }
        }


        private void frmIngreso_Load(object sender, EventArgs e)
        {
            
        }
    }
}
