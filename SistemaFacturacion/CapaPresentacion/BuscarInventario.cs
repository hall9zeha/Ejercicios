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
    public partial class BuscarInventario : Form
    {
        public BuscarInventario()
        {
            InitializeComponent();
            //this.id_Usario = (int)idUs;
        }

        private void BuscarInventario_Load(object sender, EventArgs e)
        {
            CrearGrid(); 
        }
        private void CrearGrid()
        {
            dataprod.Columns.Add("ColumnId", "Id_Prod");
            dataprod.Columns.Add("Codigo", "Codigo_prod");
            dataprod.Columns.Add("Descripcion", "Nombre_prod");
            dataprod.Columns.Add("Marca", "Marca_prod");
            dataprod.Columns.Add("Color", "Color_prod");
           
            dataprod.Columns.Add("TallaA", "TallaAlfa_prod");
            dataprod.Columns.Add("TallaN", "TallaNum_prod");
            dataprod.Columns.Add("PrecioCompra", "PrecioCompra_prod");
            dataprod.Columns.Add("PrecioVenta", "Precio_prod");
            dataprod.Columns.Add("Stock", "Stock_prod");
            dataprod.Columns.Add("Categoria", "Descripcion");


            dataprod.Columns[0].Visible = true;
            dataprod.Columns[1].Width = 150;
            dataprod.Columns[2].Width = 100;
            dataprod.Columns[3].Width = 100;
            dataprod.Columns[4].Width = 100;
            dataprod.Columns[5].Width = 100;
            dataprod.Columns[6].Width = 100;
            dataprod.Columns[7].Width = 100;
            dataprod.Columns[8].Width = 100;
            dataprod.Columns[9].Width = 100;
            dataprod.Columns[10].Width = 100;



            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataprod.ColumnHeadersDefaultCellStyle = cssCabecera;

            dataprod.AllowUserToAddRows = false;
            dataprod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Back)
                {
                    String descripcion = txtbuscar.Text;
                    int num = 0;
                    List<EProducto> Lista = NProducto.Instancia.BuscarProducto(descripcion);
                    dataprod.Rows.Clear();
                    for (int i = 0; i < Lista.Count; i++)
                    {
                        num++;
                        String[] fila = new string[] {Lista[i].Id_prod .ToString(),Lista[i].Codigo_prod,Lista[i].Nombre_prod,Lista[i].Marca_prod, Lista[i].Color_prod,
                    Lista[i].TallaAlfa_prod,Lista[i].TallaNum_prod.ToString(), Lista[i].PrecioCompra_prod.ToString(),
                    Lista[i].Precio_prod.ToString(),Lista[i].Stock_prod.ToString(),Lista[i].categoria.Descripcion     
                };
                        dataprod.Rows.Add(fila);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //prueba filtrar a travez del evento key up del textbox
            //prueba usando una lista generica
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
       
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int Id_prod = Convert.ToInt32(dataprod.CurrentRow.Cells[0].Value);
                LocalBD.Instancia.ReturnIdprod(1, Id_prod);
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //prueba de enviar id para modificar
            
           
            //prueba de enviar id para modificar
        }
    }
}
