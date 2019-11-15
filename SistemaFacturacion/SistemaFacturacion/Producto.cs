using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaEntidad;
using CapaNegocio;
namespace SistemaFacturacion
{
    public partial class Producto : Form
    {
        EProducto obj = new EProducto();
        NProducto nprod = new NProducto();
        public Producto()
        {
            InitializeComponent();
        }

        void listarProducto()
        {
            DataTable dt = nprod.ListarProducto();
            dataGridView1.DataSource = dt;

        }
        void listarComboCat()
        {
            DataTable dt = nprod.ListarCat();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Descripcion";
        }
       
        private void Producto_Load(object sender, EventArgs e)
        {
            listarProducto();
            listarComboCat();
        }
    }
}
