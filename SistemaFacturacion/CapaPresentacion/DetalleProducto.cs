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
using System.Data;
using System.Data.SqlClient;
namespace CapaPresentacion
{
    public partial class DetalleProducto : Form
    {
        EDetalle_prod obj = new EDetalle_prod();
        NProducto nobj = new NProducto(); 
        public DetalleProducto()
        {
            InitializeComponent();
        }
        void insertarDetalle()
        {
            //foreach (DataGridView row in dgvdetalle.Rows)
            //{ obj.Cod_prod = row.Cells[0].Value;
            //PRUEBA DE INSERTAR DATOS DE UNA GRILLA EN TRES CAPAS SIN USAR XML

            //}
            try
            {
                for (int i = 0; i < dgvdetalle.RowCount; i++)
                {

                    obj.Cod_prod = dgvdetalle.Rows[i].Cells[0].Value.ToString();
                    obj.Talla_A = dgvdetalle.Rows[i].Cells[1].Value.ToString();
                    obj.cantidad = Convert.ToInt32(dgvdetalle.Rows[i].Cells[2].Value.ToString());


                    nobj.GuardarDetalle(obj);
                    dgvdetalle.Rows.Clear();
                }
                MessageBox.Show("Registro ingresado");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        //prueba de guradar en buble
       
        //prueba de guardar en buble
       
        private void DetalleProducto_Load(object sender, EventArgs e)
        {

        }
        private void llenargrilla()
        {
            dgvdetalle.Rows.Add(txtcode.Text, txttalla.Text, txtcantidad.Text);

        }
        //prueba llevar a grilla
       
        //prueba llevar a grilla
        private void Button2_Click(object sender, EventArgs e)
        {
            insertarDetalle(); 
              
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            llenargrilla();
            
        }
        private void imprimirTicket()
        {

            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("COMPANY BARRY ZEHA");
            ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            ticket.TextoIzquierda("DIREC: DIRECCION DE LA EMPRESA");
            ticket.TextoIzquierda("TELEF: 4530000");
            ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            ticket.TextoIzquierda("EMAIL: vmwaretars@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # 1", "Ticket # 002-0000006");
            ticket.LineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ: " + label4.Text );
            ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.LineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.LineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            foreach (DataGridViewRow fila in dgvdetalle.Rows)//dgvLista es el nombre del datagridview
            {
                ticket.AgregarArticulo(fila.Cells[0].Value.ToString(), int.Parse(fila.Cells[2].Value.ToString()),
                decimal.Parse(fila.Cells[1].Value.ToString()), int.Parse(fila.Cells[2].Value.ToString())/*, decimal.Parse(fila.Cells[6].Value.ToString())*/);
            }
            //prueba agregar articulo a la boleta
          
         
            //prueba agregar articulo a la boleta
            //ticket.AgregarArticulo("Articulo A", 2, 20, 40);
            //ticket.AgregarArticulo("Articulo B", 1, 10, 10);
            //ticket.AgregarArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            //ticket.LineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL......$", 100);
            ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL.........$", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", 200);
            ticket.AgregarTotales("         CAMBIO........$", 0);

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera




        }
        private void Button1_Click(object sender, EventArgs e)
        {
            imprimirTicket();
        }
    }
}
