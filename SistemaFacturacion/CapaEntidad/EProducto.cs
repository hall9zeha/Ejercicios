using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EProducto
    {
        public int Id_prod { get; set; }
        public int Id_Catprod { get; set; }
        public string Codigo_prod { get; set;}
        public string Nombre_prod { get; set; }
        public string Marca_prod { get; set; }
        public string TallaAlfa_prod { get; set; }
        public int TallaNum_prod { get; set; }
        public string Color_prod { get; set; }
        public double PrecioCompra_prod { get; set; }
        public double Precio_prod { get; set; }
        public int Stock_prod { get; set; }
        public ECategoria categoria { get; set; }

       
       
    }
}
