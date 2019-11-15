using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
   public  class NUsuario
    {
        DUsuario user = new DUsuario();
        private static readonly NUsuario _instancia = new NUsuario();
        public static NUsuario Instancia
        { get { return NUsuario._instancia; } }

        public void InsertarUsuario(EUsuario obj)
        {
            user.InsertarUsuario(obj); 
        }
        public int MantenimientoUsuario(EUsuario ob)
        {
            try
            {
                string cadXml = "";
                cadXml += "<tbusuario ";
                cadXml += "nombreusuario='" + ob.NombreUsuario  + "' ";
                cadXml += "apellidousuario='" + ob.ApellidoUsuario + "' ";
                cadXml += "claveusuario='" + ob.ClaveUsuario + "' ";
                cadXml += "nivelacceso='" + ob.NivelAcceso + "' ";
                cadXml += "fotousuario='" + ob.FotoUsuario + "'/>";
                cadXml = "<root>" + cadXml + "</root>";
                int result = DUsuario.Instancia.RegistrarUsuario(cadXml);  
                if (result <= 0) throw new ApplicationException("Ocurrio un error al registrar");
                return result;

            }
            catch (Exception)
            { throw; }


        }
        //prueba xml
       
        //prueba xml
        public DataTable ListarUsuario()
        {
            try
            {
                return user.ListarUsuario(); 
            }
            catch (Exception)
            { throw; }
        }

        public  List<EUsuario> ListarUsuario1()
        {
            try
            {
                List<EUsuario> lista = null;
                lista = DUsuario.Instancia.ListarUsuario1();
                return lista;
            }
            catch (Exception)
            { throw; }
        }

        public EUsuario VerificarAcceso(String usuario, String clave )
        {
            try
            {
                if (usuario == "") throw new ApplicationException("ingrese un usuario");
                if (clave == "") throw new ApplicationException("ingrese una clave");
                EUsuario e = null;
                e = DUsuario.Instancia.VerificarAcceso(usuario, clave);
                if (e == null)
                {
                    throw new ApplicationException("usuario o password inválido");
                }
                return e;
            }
            catch (Exception)
            { throw; }
        }
        //prueba login

        //prueba login
        //PRUEBA DE MÉTODOS PARA CARGAR IMAGEN
        public List<EUsuario> MostrarTodos()
        {
            List<EUsuario> lista = null;
            lista = DUsuario.Instancia.ObtenerTodos();
            return lista;
        }
        //PRUEBA DE MÉTODOS PARA CARGAR IMAGEN
    }
}
