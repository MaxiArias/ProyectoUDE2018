using System;
using System.Linq;
using Modelo.ValueObjects;

namespace LogicaPersistencia.DAO
{
    public class CarritoDAO
    {
        public void InsertarCarrito(CarritoVO carvo)
        {
            Carrito ca = new Carrito(carvo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Carrito.Add(ca);
                db.SaveChanges();
            }
        }

        public void BorrarCarrito(CarritoVO carvo)
            {
                using (TiendaVirtualEntities db = new TiendaVirtualEntities())
                {
                    db.Entry(carvo).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }

        public void ModificarCarrito(CarritoVO carvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(carvo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public bool ExisteCarro(int idusuario)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var primerIdUsuario = (from back in db.Carrito
                                               where back.UsuarioId == idusuario
                                               select back).FirstOrDefault();

                return primerIdUsuario != null;
            }
        }


        public CarritoVO DarCarro (int idusuario)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                return db.Carrito.Contains(idusuario);
            }
        }
       
    }
}
