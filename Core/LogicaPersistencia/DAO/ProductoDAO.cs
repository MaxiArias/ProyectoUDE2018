using Modelo.ValueObjects;
using System.Collections.Generic;

namespace LogicaPersistencia.DAO
{
    public class ProductoDAO
    {
        public void InsertarProducto(ProductoVO prodvo)
        {
            Producto pr = new Producto(prodvo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Producto.Add(pr);
                db.SaveChanges();
            }
        }

        public void BorrarProducto(ProductoVO prodvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(prodvo).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void ModificarProducto(ProductoVO prodvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(prodvo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
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
