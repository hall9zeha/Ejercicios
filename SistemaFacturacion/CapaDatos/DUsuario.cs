using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DUsuario
    {
        private static readonly DUsuario _instancia = new DUsuario();
        public static DUsuario Instancia
        {
            get { return DUsuario._instancia; }
        }

        SqlConnection cn = Conexion.Instancia.Conectar();
        //prueba de usuario

        //prueba de usuario

        public int RegistrarUsuario(String cadXml)
        {
            SqlCommand cmd = null;
            var result = 0;
            try

            {
                cmd = new SqlCommand("spMantenerUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmCadXML", cadXml);
                cn.Open();
                result = cmd.ExecuteNonQuery();
                return result;

            }
            catch (Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
        }

        //procedimiento normal para probar el error del insertado binario en xml
        public void InsertarUsuario(EUsuario e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insertusuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreUsuario", e.NombreUsuario);
                cmd.Parameters.AddWithValue("@ApellidoUsuario", e.ApellidoUsuario);
                cmd.Parameters.AddWithValue("@ClaveUsuario", e.ClaveUsuario);
                cmd.Parameters.AddWithValue("@NivelAcceso", e.NivelAcceso);
                //cmd.Parameters.AddWithValue("@FotoUsuario", e.FotoUsuario);
                SqlParameter imageParam = cmd.Parameters.Add("@FotoUsuario", System.Data.SqlDbType.Image);
                imageParam.Value = e.FotoUsuario;
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception)
            { throw; }
        }
        //
        public DataTable ListarUsuario()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("spListarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            { throw; }
        }
        //este método funciona mejor cuando traes datos binarios a un datagrid
        public List<EUsuario> ListarUsuario1()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<EUsuario> lista;
            EUsuario e = null;
            try
            {
                cmd = new SqlCommand("spListarUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                lista = new List<EUsuario>();
                while (dr.Read())
                {
                    e = new EUsuario();
                    e.IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                    e.NombreUsuario = dr["NombreUsuario"].ToString();
                    e.ApellidoUsuario = dr["ApellidoUsuario"].ToString();
                    e.ClaveUsuario = dr["ClaveUsuario"].ToString();
                    e.NivelAcceso = Convert.ToInt32(dr["NivelAcceso"].ToString());
                    e.FotoUsuario = (byte[])dr["FotoUsuario"];

                    lista.Add(e);
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return lista;
        }
        //este método funciona mejor cuando traes datos binarios a un datagrid
        //prueba login

        //prueba login
        //método para logearse
        public EUsuario VerificarAcceso(String usuario, String clave)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            EUsuario e = null;
            try
            {
                cmd = new SqlCommand("spVerificarAcceso", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Password", clave);
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    e = new EUsuario();
                    e.IdUsuario = Convert.ToInt32(dr["IdUsuario"].ToString());
                    e.NombreUsuario = dr["NombreUsuario"].ToString();
                    e.ApellidoUsuario = dr["ApellidoUsuario"].ToString();
                    e.NivelAcceso = Convert.ToInt32(dr["NivelAcceso"].ToString());


                }
            }
            catch (Exception)
            { throw; }
            finally { cmd.Connection.Close(); }
            return e;
        }

        //métodos de prueba para cargar imagen
        public List<EUsuario> ObtenerTodos()
        {
            //List<EUsuario> lista = new List<EUsuario>();

            //SqlConnection cnn = Conexion.Instancia.Conectar();

            //SqlCommand cmd = new SqlCommand("spListarUsuarioPrueba", cnn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cnn.Open();
            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    lista.Add(ConvertirImagen(reader));
            //}



            //return lista;
            List<EUsuario> lista = new List<EUsuario>();

            using (SqlConnection conn = new SqlConnection("data source=./; initial catalog=StoreDress; integrated security=true "))
            {
                conn.Open();

                string query = @"SELECT IdUsuario, NombreUsuario, ApellidoUsuario,ClaveUsuario, NivelAcceso, FotoUsuario
                                 FROM tbUsuario";
                //string query = @"SELECT IdEmpleado, Nombre, Apellido, Imagen
                //                 FROM Empleados";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(ConvertirImagen(reader));
                }
                return lista;

            }


        }


        public EUsuario ConvertirImagen(IDataReader dr)
        {
            EUsuario e = new EUsuario();
            e.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
            e.NombreUsuario = dr["NombreUsuario"].ToString();
            e.ApellidoUsuario = dr["ApellidoUsuario"].ToString();
            e.ClaveUsuario = dr["ClaveUsuario"].ToString();
            e.NivelAcceso = Convert.ToInt32(dr["NivelAcceso"]);
            if (dr["FotoUsuario"] != DBNull.Value)
                e.FotoUsuario = (byte[])dr["FotoUsuario"];

            //e.IdUsuario = Convert.ToInt32(dr["IdEmpleado"]);
            //e.NombreUsuario = dr["Nombre"].ToString();
            //e.ApellidoUsuario = dr["Apellido"].ToString();

            //if (dr["Imagen"] != DBNull.Value)
            //    e.FotoUsuario = (byte[])dr["Imagen"];
            return e;
        }

        //métodos de prueba para cargar imagen


    }
}

