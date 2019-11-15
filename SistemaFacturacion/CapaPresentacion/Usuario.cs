using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using CapaDatos;
using System.IO;
namespace CapaPresentacion
{
    public partial class Usuario : Form
    {
        EUsuario eu = new EUsuario();
        NUsuario nu = new NUsuario();
        DataTable dtu = new DataTable();
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            
            listarUsuario();


        }
        void listarUsuario()
        {
            try
            {
                //dtu = nu.ListarUsuario();
                //datauser.DataSource = dtu;
                //datauser.DataSource = NUsuario.Instancia.MostrarTodos();
                //datalog.AutoGenerateColumns = false;
                datalog.DataSource = DUsuario.Instancia.ObtenerTodos();
                //prueba de codigo para cargar imagen
                foreach (DataGridViewRow row in datalog.Rows)
                {
                    //se asigna el alto de la fila para poder ver la imagen correctamente
                    //row.Height = 120;

                    //se recupera la entidad que es asignada como dato
                    EUsuario usuario = row.DataBoundItem as EUsuario;

                    if (usuario.FotoUsuario == null)
                        row.Cells["FotoUsuario"].Value = ImageHelper.ObtenerImagenNoDisponible();
                    else
                        row.Cells["FotoUsuario"].Value = ImageHelper.ByteArrayToImage(usuario.FotoUsuario);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            //prueba para cargar imagen

        }
        void listarUsuario1()
        {
            
            datalog.DataSource = NUsuario.Instancia.ListarUsuario1();
        }
        void registraUsuario()
        {
           
            try
            {
                eu.NombreUsuario = txtnom.Text;
                eu.ApellidoUsuario = txtape.Text;
                eu.ClaveUsuario = txtclave.Text;
                eu.NivelAcceso = Convert.ToInt32(cmbnivel.SelectedIndex + 1);
                eu.FotoUsuario = ImageHelper.ImageToByteArray(pictureBox1.Image);
                int i = NUsuario.Instancia.MantenimientoUsuario(eu);

                MessageBox.Show("Registrado con éxito");
            }
            catch (Exception ex)
            { MessageBox.Show("Error", ex.Message); }

        }
        //prueba presentacionxml


        //prueba presentacionxml

        //método normal de insercion para probar error binario
        private void insertarUsuario()
        {
           

            //try
            //{
            eu.NombreUsuario = txtnom.Text;
                eu.ApellidoUsuario = txtape.Text;
            eu.ClaveUsuario = txtclave.Text;
            eu.NivelAcceso = Convert.ToInt32(cmbnivel.SelectedIndex + 1);
            eu.FotoUsuario = ImageHelper.ImageToByteArray(pictureBox1.Image);
            nu.InsertarUsuario(eu);

                MessageBox.Show("Registrado con éxito");
            //}
            //catch (Exception ex)
            //{ MessageBox.Show("Error", ex.Message); }

        }
        //

        private void Button1_Click(object sender, EventArgs e)
        {
            //registraUsuario();
            insertarUsuario();
            listarUsuario();
            limpiar();

        }
        void limpiar()
        {
            txtnom.Clear();
            txtape.Clear();
            txtclave.Clear();
            cmbnivel.Text = "";
        }
       

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivo JPG|*.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fileDialog.FileName);
            }
        }
       

        private void Datauser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Datauser_SelectionChanged(object sender, EventArgs e)
        {
           
            ////try
            ////{
            //    var row = (sender as DataGridView).CurrentRow;
            //    byte[] imageBuffer = (byte[])row.Cells[5].Value; //almacenas la imagen de la datagrib
            //    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);//
               

            //    txtnom.Text = row.Cells[1].Value.ToString();
            //    txtape.Text = row.Cells[2].Value.ToString();
            //    //txtclave.Text = row.Cells[3].Value.ToString();
            //    cmbnivel.SelectedIndex  = Convert.ToInt32(row.Cells[4].Value.ToString()) - 1;
            ////pictureBox1.Image = Image.FromStream(ms);//le asignas al pictureBox
            ////pictureBox1.Image = ImageHelper.ByteArrayToImage(eu.FotoUsuario);
            ////}
            ////catch (Exception ex)
            ////{ MessageBox.Show(ex.Message); }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listarUsuario(); 
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
