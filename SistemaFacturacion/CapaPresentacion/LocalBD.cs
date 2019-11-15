using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacion
{
    class LocalBD
    {
        int IdProd = 0;

        private static readonly LocalBD _instancia=new LocalBD();
        public static LocalBD Instancia
        { get { return LocalBD._instancia; } }
        public int ReturnIdprod(int getset, int idprod)
        {
            try
            {
                if (getset == 1)
                {
                    IdProd = idprod;
                }
                return IdProd;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //prueba de entidades
       
        //prueba de entidades
    }
}
