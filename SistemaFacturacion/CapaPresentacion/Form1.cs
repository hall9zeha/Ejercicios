using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        //Int32 idUsuario;

        EProducto obj = new EProducto();
        NProducto nobj = new NProducto();
        DataTable dt = new DataTable();
        //prueba de instanciamiento
       
        //prueba de instanciamiento
        
        public Form1()
        {
            InitializeComponent();
            //idUsuario = (Int32)id_Usuario;
        }
        void cargarcombo()
        {
            /*DataTable*/ dt = nobj.ListarCat();
            cmbcat.DataSource = dt;
            cmbcat.DisplayMember = "Descripcion"; 
        }
        //cargar combo categoria con lista
        void cargarComboCatLista()
        {
            cmbcat.DisplayMember = "Descripcion";
            cmbcat.DataSource = nobj.LlenarComboCat();
            //cmbcat.DataSource = NProducto.Instancia.LlenarComboCat();  
        }
        //cargar combo categoria con lista
        //prueba
       
        //prueba

               void listarProducto()
        {
            /*DataTable*/ dt = nobj.ListarProducto();
            dataprod.DataSource = dt;
        }

        void ingresarProducto()
        {
            try
            {
                if (txtnom.Text == "") obj.Nombre_prod = "Desconocido"; else obj.Nombre_prod = txtnom.Text;
                if (txtmarca.Text == "") obj.Marca_prod = "Desconocido";else  obj.Marca_prod = txtmarca.Text;
                if (txttalla1.Text == "") obj.TallaAlfa_prod = "Desconocido"; else obj.TallaAlfa_prod = txttalla1.Text;
                if (txttalla2.Text == "") obj.TallaNum_prod = 0; else obj.TallaNum_prod = Convert.ToInt32(txttalla2.Text);
                if (txtcolor.Text == "") obj.Color_prod = "Desconocido"; else obj.Color_prod = txtcolor.Text;
                if (txtprecom.Text == "") obj.PrecioCompra_prod = 0;else obj.PrecioCompra_prod = Convert.ToDouble(txtprecom.Text);
                if (txtpreven.Text == "") obj.Precio_prod = 0;else obj.Precio_prod = Convert.ToDouble(txtpreven.Text);
                if (txtstock.Text == "") obj.Stock_prod = 0;else obj.Stock_prod = Convert.ToInt32(txtstock.Text);
                
              if (String.IsNullOrEmpty(Convert.ToString(cmbcat.SelectedValue))) throw new ApplicationException("Debe seleccionar una categoria ");
                else obj.Id_Catprod = cmbcat.SelectedIndex + 1;
                nobj.InsertarProd(obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //prueba insertar
        
        //prueba insertar

        void EditarProducto()
        {
            try
            {
                obj.Id_Catprod = cmbcat.SelectedIndex + 1;
                obj.Nombre_prod = txtnom.Text;
                obj.Marca_prod = txtmarca.Text;
                obj.TallaAlfa_prod = txttalla1.Text;
                obj.TallaNum_prod = Convert.ToInt32(txttalla2.Text);
                obj.Color_prod = txtcolor.Text;
                obj.PrecioCompra_prod = Convert.ToDouble(txtprecom.Text);
                obj.Precio_prod = Convert.ToDouble(txtpreven.Text);
                obj.Stock_prod = Convert.ToInt32(txtstock.Text);
                obj.Id_prod = Convert.ToInt32(labelcod.Text);
                nobj.EditarProducto(obj);
                MessageBox.Show("Editado correctamente");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        
        void eliminarProducto()
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea eliminar Registro seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    obj.Id_prod = Convert.ToInt32(labelcod.Text);
                    nobj.EliminarProducto(obj);
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }

            //prueba eliminar
         
            //prueba eliminar
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form Login = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Login);
            // si existe una instancia de frmlogeo:  visible = false (oculta)
            if (Login != null)
            {
                Login.Visible = false;
            }

            dataprod.AllowUserToResizeColumns = false;
            dataprod.AllowUserToResizeRows = false;
            dataprod.ReadOnly = false;
            dataprod.Focus(); 
            HabilitarBtn(false, false, false);
            //cargarcombo();
            cargarComboCatLista();
            listarProducto();
        }
        public void HabilitarBtn(Boolean guardar, Boolean editar, Boolean eliminar)

        {
            btnguardar.Enabled = guardar;
            btneditar.Enabled = editar;
            btneliminar.Enabled = eliminar;

        }
        //prueba boleana habilitar botones
    
        //prueba boleana habilitar botones

        private void Button1_Click(object sender, EventArgs e)
        {
            ingresarProducto();
            listarProducto();
            limpiar();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var row = (sender as DataGridView).CurrentRow;
                labelcod.Text = row.Cells[0].Value.ToString();
                txtnom.Text = row.Cells[2].Value.ToString();
                txtmarca.Text = row.Cells[3].Value.ToString();
                txttalla1.Text = row.Cells[7].Value.ToString();
                txttalla2.Text = row.Cells[8].Value.ToString();
                txtcolor.Text = row.Cells[4].Value.ToString();
                txtprecom.Text = row.Cells[5].Value.ToString();
                txtpreven.Text = row.Cells[6].Value.ToString();
                txtstock.Text = row.Cells[9].Value.ToString();
                cmbcat.Text = row.Cells[10].Value.ToString();

              
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            //prueba selecction change dentro del evento selection change del datagrid
           
            
          //prueba selection change


        }

       

        void limpiar()
        {
            labelcod.Text = "";
            txtnom.Clear();
            txtmarca.Clear();
            txttalla1.Clear();
            txttalla2.Clear();
            txtcolor.Clear();
            txtprecom.Clear();
            txtpreven.Clear();
            txtstock.Clear();
            cmbcat.Text = "";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            limpiar();
            HabilitarBtn(true, true, true); 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            EditarProducto();
            limpiar();
            listarProducto();
        }

        private void Txtbuscar_TextChanged(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            try
            {
                string fieldName = string.Concat("[", dt.Columns[2].ColumnName, "]");
                dt.DefaultView.Sort = fieldName;
                DataView view = dt.DefaultView;
                view.RowFilter = string.Empty;
                if (txtbuscar.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + txtbuscar.Text + "%'";
                dataprod.DataSource = view;

               
            }
            catch (Exception)
            { throw; }


            //prueba de filtro en evento textchange del textbox
           
            //prueba filtro

        }


        private void Button4_Click(object sender, EventArgs e)
        {
            eliminarProducto();
            limpiar();
            listarProducto(); 
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            try
            {
                //BuscarInventario frmProdBuscar = new BuscarInventario();
                //frmProdBuscar.MdiParent = this.ParentForm;

                BuscarInventario buscarform = new BuscarInventario();
                buscarform.ShowDialog();
                int id = LocalBD.Instancia.ReturnIdprod(0, 0);
                for (int i = 0; i < dataprod.RowCount; i++)
                {
                    if (Convert.ToInt32(dataprod.Rows[i].Cells[0].Value) == id)
                    {
                        dataprod.Rows[i].Selected = true;
                        Mostrarfila_select(id);
                        LocalBD.Instancia.ReturnIdprod(1, 0);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //prueba de buscar para editar
            
            //prueba de buscar para editar

        }

        private void Mostrarfila_select(int id_prod)
        {
            try
            {
                EProducto p = null;
                // int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                p = NProducto.Instancia.BuscarProductoGrid(id_prod);
                labelcod.Text = p.Id_prod.ToString();
                txtnom.Text = p.Nombre_prod;
                txtmarca.Text = p.Marca_prod;
                txttalla1.Text = p.TallaAlfa_prod; 
                txttalla2.Text = p.TallaNum_prod.ToString();
                txtcolor.Text = p.Color_prod; 
                txtprecom.Text = p.PrecioCompra_prod.ToString();
                txtpreven.Text = p.Precio_prod.ToString();
                txtstock.Text = p.Stock_prod.ToString();
                cmbcat.SelectedIndex  = p.categoria.Cod_cat;
                //comboBox1.SelectedValue = p.categoria.Descripcion; 

                
            }
            catch (Exception)
            {

                throw;
            }
        }
        //prueba mostrarfilaselect
      
        //prueba mostrarfilaselect

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DetalleProducto DET = new DetalleProducto();
            DET.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
                      enviarIdProducto(); 
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.ShowDialog();
        }
        private void enviarIdProducto()
        {
            try
            {
                int id_prod = Convert.ToInt32(dataprod.CurrentRow.Cells[0].Value);
                DetalleBusquedaProd Det = new DetalleBusquedaProd(id_prod);
                Det.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
