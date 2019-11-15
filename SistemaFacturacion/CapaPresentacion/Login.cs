using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
        }
        void VerificarAcceso()
        {

            try
            {
                String usuario = txtuser.Text;
                String clave = txtpass.Text;

                EUsuario e = null;
                e = NUsuario.Instancia.VerificarAcceso(usuario, clave);
                
                Form1 principal = new Form1();
                principal.Show();
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        //prueba verificar acceso
      

        //prueba verificar acceso

        private void Button1_Click(object sender, EventArgs e)
        {
            VerificarAcceso(); 
        }
    }
}
