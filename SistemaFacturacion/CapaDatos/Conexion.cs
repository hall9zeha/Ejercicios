using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion _intancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._intancia; }
        }

        //prueba de instancia


        //prueba de instancia

        //prueba de conexion
    
        //prueba de conexion
        public SqlConnection  Conectar()
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "data source=./;initial catalog=StoreDress;integrated security=true";
                return cn;
            }
            catch (Exception)

            {
                throw;
                    
                    }
                }
      
      
    }
}
