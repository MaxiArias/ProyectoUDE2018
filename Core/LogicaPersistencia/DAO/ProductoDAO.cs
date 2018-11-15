using Modelo.ValueObjects;
using System.Collections.Generic;

namespace LogicaPersistencia.DAO
{
    public class ProductoDAO
    {
        public void InsertarProducto(ProductoVO prodvo)
        {
            //aca va el insert y la conexion a la base de datos.    
        }

        public void BorrarProducto(int proid)
        {
            //aca va el delete y la conexion a la base de datos.    
        }

        public void ModificarProducto(ProductoVO prodvo)
        {
            //aca va el update y la conexion a la base de datos.    
        }

        public void ModificarStockProducto(ProductoVO prodvo)
        {
            //aca va el update y la conexion a la base de datos.    
        }

        public ProductoVO DarProductoPorID(ProductoVO prodvo)
        {
            int idproducto = prodvo.IdProducto;
                return prodvo;
                //aca va el update y la conexion a la base de datos.    
        }

        public List<ProductoVO> ListarProductoPorCategoria(ProductoVO prodvo)
        {
            return null;
            //aca va el update y la conexion a la base de datos.    
        }

        public List<ProductoVO> ListarProductoPorDescripcion(ProductoVO prodvo)
        {
            return null;
            //aca va el update y la conexion a la base de datos.    
        }

        public List<ProductoVO> ListarProductos()
        {
            return null;
            //aca va el update y la conexion a la base de datos.    
        }

    }

}
