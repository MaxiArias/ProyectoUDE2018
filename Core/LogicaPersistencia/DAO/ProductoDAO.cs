using Modelo.ValueObjects;
using System.Collections.Generic;
using System.Linq;

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

        public void BorrarProducto(int idprod)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var producto = db.Producto.Where(s => s.ProductoId == idprod).FirstOrDefault();
                db.Producto.Remove(producto);
                db.SaveChanges();
            }
        }

        public void ModificarProducto(ProductoVO prodvo)
        {
            
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var producto = db.Producto.Where(s => s.ProductoId == prodvo.IdProducto).FirstOrDefault();
                producto.ProductoNombre = prodvo.Nombre;
                producto.ProductoDescripcion = prodvo.Descripcion;
                producto.ProductoHabilitado = prodvo.Habilitado;
                producto.ProductoPrecio = prodvo.Precio;
                producto.ProductoStock = prodvo.Stock;
                db.SaveChanges();
            }
        }

        public void ModificarStockProducto(int idprod, int cantstock)
        {

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var producto = db.Producto.Where(s => s.ProductoId == idprod).FirstOrDefault();
                producto.ProductoStock = cantstock;
                db.SaveChanges();
            }
         }

        public void HabilitarProducto (int idprod, bool habilito)
        {

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var producto = db.Producto.Where(s => s.ProductoId == idprod).FirstOrDefault();
                producto.ProductoHabilitado = habilito ;
                db.SaveChanges();
            }

        }
        public ProductoVO DarProductoPorID(int idprod)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var producto = db.Producto.Where(s => s.ProductoId == idprod).FirstOrDefault();
       
                return producto.DarProductoVO();
            }

        }

        public List<ProductoVO> ListarProductoPorCategoria(int idcatego)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var producto = db.Producto.Where(s => s.CategoriaId== idcatego).ToList();

                return producto.Select(back => back.DarProductoVO()).ToList();
            }
        }

        public List<ProductoVO> ListarProductoPorCategoriaHabilitado(int idcatego)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var producto = db.Producto.Where(s => s.CategoriaId == idcatego && s.ProductoHabilitado==true).ToList();

                return producto.Select(back => back.DarProductoVO()).ToList();
            }
        }


        public List<ProductoVO> ListarProductos()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                return db.Producto.ToList().Select(back => back.DarProductoVO()).ToList();
            }
        }

        public List<ProductoVO> ListarProductosHabilitados()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var producto = db.Producto.Where(s => s.ProductoHabilitado == true).ToList();

                return producto.Select(back => back.DarProductoVO()).ToList();
            }
        }


    }

}
