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
    public partial class DetalleBusquedaProd : Form
    {//constructor para tomar el parametro de id enviado del otro formulario
        
        EProducto p;
        int id_prod;
        //prueba de vaiables globales para recibir idProducto
        
        //prueba de vaiables globales para recibir idProducto

        public DetalleBusquedaProd(int idprod)
        {
            InitializeComponent();
            this.id_prod = idprod;
            //
            
            //
            
        }
        //id_prod e idprod creados para tomar el id_prod del formulario form1
        //prueba de buscar producto detalle
       
        //prueba de buscar producto detalle
        private void llenarDetalle()
        {
            try
            {
                p = NProducto.Instancia.BuscarDetalleProducto(this.id_prod);
                txtid.Text = p.Id_prod.ToString();
                txtcat.Text = p.categoria.Descripcion;
                txtcod.Text = p.Codigo_prod;
                txtprod.Text = p.Nombre_prod;
                txtmarca.Text = p.Marca_prod;
                txttalla1.Text = p.TallaAlfa_prod;
                txttalla2.Text = p.TallaNum_prod.ToString();
                txtcolor.Text = p.Color_prod;
                txtprecomp.Text = p.PrecioCompra_prod.ToString();
                txtprefinal.Text = p.Precio_prod.ToString();
                txtstock.Text = p.Stock_prod.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void DetalleBusquedaProd_Load(object sender, EventArgs e)
        {
            llenarDetalle(); 

        }
    }
}
