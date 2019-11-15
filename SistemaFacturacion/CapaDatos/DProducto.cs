using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class DProducto
    {
        private static readonly DProducto _instancia = new DProducto();
        public static DProducto Instancia
        {
            get { return DProducto._instancia; }
        }


        SqlConnection cn = Conexion.Instancia.Conectar();
        //prueba instancia y cadena
        
     
        //prueba de instancia y cadena

        public DataTable ListarCat()
        {
            SqlCommand cmd = new SqlCommand("sp_Listarcat", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }

        //prueba llamar con datatable
       
        //prueba llamar con datatable

        public DataTable ListarProducto()
        {
            SqlCommand cmd = new SqlCommand("sp_listarprod", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //prueba de insertar
       

        //prueba de insertar
        public void InsertarProducto(EProducto obj)
        { try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Catprod", obj.Id_Catprod);
                cmd.Parameters.AddWithValue("@Nombre_prod", obj.Nombre_prod);
                cmd.Parameters.AddWithValue("@Marca_prod", obj.Marca_prod);
                cmd.Parameters.AddWithValue("@TallaAlfa_prod", obj.TallaAlfa_prod);
                cmd.Parameters.AddWithValue("@TallaNum_prod", obj.TallaNum_prod);
                cmd.Parameters.AddWithValue("@Color_prod", obj.Color_prod);
                cmd.Parameters.AddWithValue("@PrecioCompra_prod", obj.PrecioCompra_prod);
                cmd.Parameters.AddWithValue("@Precio_prod", obj.Precio_prod);
                cmd.Parameters.AddWithValue("@Stock_prod", obj.Stock_prod);
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void EditarProducto(EProducto obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EditarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Catprod", obj.Id_Catprod);
                cmd.Parameters.AddWithValue("@Nombre_prod", obj.Nombre_prod);
                cmd.Parameters.AddWithValue("@Marca_prod", obj.Marca_prod);
                cmd.Parameters.AddWithValue("@TallaAlfa_prod", obj.TallaAlfa_prod);
                cmd.Parameters.AddWithValue("@TallaNum_prod", obj.TallaNum_prod);
                cmd.Parameters.AddWithValue("@Color_prod", obj.Color_prod);
                cmd.Parameters.AddWithValue("@PrecioCompra_prod", obj.PrecioCompra_prod);
                cmd.Parameters.AddWithValue("@Precio_prod", obj.Precio_prod);
                cmd.Parameters.AddWithValue("@Stock_prod", obj.Stock_prod);
                cmd.Parameters.AddWithValue("@Id_Prod", obj.Id_prod);
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception)
            { throw; }

        }
        public void EliminarProducto(EProducto obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Prod", obj.Id_prod);
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            { throw; }
        }

        //prueba lista
   
        //prueba lista

        public List<EProducto> BuscarProducto(string nombre)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<EProducto> lista = null;
            try
            {
                cmd = new SqlCommand("sp_Buscarprod", cn);
                cmd.Parameters.AddWithValue("@Nombre_prod", nombre);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                lista = new List<EProducto>();
                while (dr.Read())
                {
                    EProducto p = new EProducto();
                    p.Id_prod = Convert.ToInt32(dr["Id_Prod"].ToString());

                    p.Codigo_prod = dr["Codigo_prod"].ToString();
                    p.Nombre_prod = dr["Nombre_prod"].ToString();
                    p.Marca_prod = dr["Marca_prod"].ToString();
                    p.Color_prod = dr["Color_prod"].ToString();

                    p.PrecioCompra_prod = Convert.ToDouble(dr["PrecioCompra_prod"].ToString());
                    p.Precio_prod = Convert.ToDouble(dr["Precio_prod"].ToString());
                    p.TallaAlfa_prod = dr["TallaAlfa_prod"].ToString();
                    p.TallaNum_prod = Convert.ToInt32(dr["TallaNum_prod"].ToString());
                    p.Stock_prod = Convert.ToInt32(dr["Stock_prod"].ToString());
                    //p.Id_Catprod = Convert.ToInt32(dr["Id_Catprod"].ToString());
                    ECategoria c = new ECategoria();
                    c.Descripcion = dr["Descripcion"].ToString();
                    p.categoria = c;
                    lista.Add(p);



                }

            }
            catch (Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        //método para llenar un combobox sin usar dataset sino usando una lista
        public List<ECategoria> LlenarComboCat()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<ECategoria> lista = null;
            try
            {
                cmd = new SqlCommand("spListarCatList", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                lista = new List<ECategoria>();
                while (dr.Read())
                {
                    ECategoria p = new ECategoria();
                    p.Cod_cat = Convert.ToInt32(dr["Cod_cat"].ToString());
                    p.Codigo = dr["Codigo"].ToString();
                    p.Descripcion = dr["Descripcion"].ToString();
                    lista.Add(p);

                }

            }
            catch (Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        //método para llenar un combobox sin usar dataset sino usando una lista
       
       
        //método para traer el detalle del producto
        public EProducto BuscarDetalleProducto(int id_prod)
        {
            SqlCommand cmd = null;
            IDataReader idr = null;
            EProducto p = null;

            try
            {
                cmd = new SqlCommand("spMostrarDetalleProd", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProd", id_prod);
                cn.Open();
                idr = cmd.ExecuteReader();
                if(idr.Read())
                {
                    p = new EProducto();
                    p.Id_prod = Convert.ToInt32(idr["Id_Prod"].ToString());
                    ECategoria c = new ECategoria();
                    c.Descripcion = idr["Descripcion"].ToString();
                    p.categoria = c;
                    p.Codigo_prod = idr["Codigo_prod"].ToString();
                    p.Nombre_prod = idr["Nombre_prod"].ToString();
                    p.Marca_prod = idr["Marca_prod"].ToString();
                    p.TallaAlfa_prod = idr["TallaAlfa_prod"].ToString();
                    p.TallaNum_prod = Convert.ToInt32(idr["TallaNum_prod"].ToString());
                    p.Color_prod = idr["Color_prod"].ToString();
                    p.PrecioCompra_prod = Convert.ToDouble(idr["PrecioCompra_prod"].ToString());
                    p.Precio_prod = Convert.ToDouble(idr["Precio_prod"].ToString());
                    p.Stock_prod = Convert.ToInt32(idr["Stock_prod"].ToString());


                    

                }
            }
            catch(Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
            return p;
        }

        //método para traer el detalle del producto

        //prueba buscar
      

        //prueba buscar

        public EProducto BuscarProductoGrid(int Id_Prod)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            EProducto p = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("sp_BuscarPorId", cn);
                cmd.CommandType =  CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Prod", Id_Prod);
                cn.Open();
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                   p = new EProducto();
                    p.Id_prod = Convert.ToInt32(dr["Id_Prod"].ToString());

                    p.Codigo_prod = dr["Codigo_prod"].ToString();
                    p.Nombre_prod = dr["Nombre_prod"].ToString();
                    p.Marca_prod = dr["Marca_prod"].ToString();
                    p.Color_prod = dr["Color_prod"].ToString();

                    p.PrecioCompra_prod = Convert.ToDouble(dr["PrecioCompra_prod"].ToString());
                    p.Precio_prod = Convert.ToDouble(dr["Precio_prod"].ToString());
                    p.TallaAlfa_prod = dr["TallaAlfa_prod"].ToString();
                    p.TallaNum_prod = Convert.ToInt32(dr["TallaNum_prod"].ToString());
                    p.Stock_prod = Convert.ToInt32(dr["Stock_prod"].ToString());
                    //p.Id_Catprod = Convert.ToInt32(dr["Id_Catprod"].ToString());
                    ECategoria c = new ECategoria();
                    c.Descripcion = dr["Descripcion"].ToString();
                    p.categoria = c;
                    

                }
            }

            catch (Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
            return p;
        }

        public void GuardarDetalle(EDetalle_prod obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarDetalle", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod_prod", obj.Cod_prod);
                cmd.Parameters.AddWithValue("@Talla_A", obj.Talla_A);
                cmd.Parameters.AddWithValue("@Cantidad", obj.cantidad);
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            { throw; }

        }

    }
}
