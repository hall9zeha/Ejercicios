using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocio
{
    public class NProducto
    {

        private static readonly NProducto _instancia = new NProducto();
        public static NProducto Instancia
        {
            get { return NProducto._instancia; }
        }
        DProducto Dprod = new DProducto();
        public DataTable ListarCat()
        {
            return Dprod.ListarCat();
        }
        //prueba
       
        //prueba


        public DataTable ListarProducto()
        {
            return Dprod.ListarProducto();
        }
        public void InsertarProd(EProducto obj)
        { Dprod.InsertarProducto(obj); }

        public void EditarProducto(EProducto editar)
        {
            Dprod.EditarProducto(editar);
        }
        public void EliminarProducto(EProducto eliminar)
        {
            Dprod.EliminarProducto(eliminar);
        }

        public List<EProducto> BuscarProducto(string nombre)
        {
            try
            {
                List<EProducto> lista = null;
                lista = DProducto.Instancia.BuscarProducto(nombre);
                return lista;


            }
            catch (Exception)
            { throw; }
        }


        public void GuardarDetalle(EDetalle_prod detalle)
        {
            Dprod.GuardarDetalle(detalle);
        }
        public EProducto BuscarProductoGrid(int id_prod)
        {
            try
            {
                EProducto p = null;
                p = DProducto.Instancia.BuscarProductoGrid(id_prod);
                if (p == null) throw new ApplicationException("No se encontro producto seleccionado en la BD");
                return p;
            }
            catch (Exception)
            { throw; }
        }
        //llenar combo con lista
        public List<ECategoria> LlenarComboCat()
        {
            List<ECategoria> lista = null;
            lista = DProducto.Instancia.LlenarComboCat();
            return lista;

        }
        //llenar combo con lista

        //Llamar detalle producto
        public EProducto BuscarDetalleProducto(int id_prod)
        {
            try
            {
                EProducto p = null;
                p = DProducto.Instancia.BuscarDetalleProducto(id_prod);
                if (p == null) throw new ApplicationException("Ocurrio un error al cargar el detalle revisa en que te equivocaste");
                return p;
            }
            catch (Exception)
            { throw; }

        }

        //Llamar detalle producto

        //prueba de buscargrid
     
        //prueba de buscar grid


    }

}
