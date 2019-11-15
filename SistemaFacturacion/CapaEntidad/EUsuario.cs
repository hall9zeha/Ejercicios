using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public  class EUsuario
    {
      public  int IdUsuario { get; set; }
        public String NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public String ClaveUsuario { get; set; }
        public int NivelAcceso { get; set; }
        public byte[] FotoUsuario { get; set; }
    }
}
