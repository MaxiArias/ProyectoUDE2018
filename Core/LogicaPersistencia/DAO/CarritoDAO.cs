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

        public void BorrarCarrito(int idcarro)
            {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var carro = db.Carrito.Where(s => s.CarritoId == idcarro).FirstOrDefault();
                db.Carrito.Remove(carro);
                db.SaveChanges();
            }
        }

        public bool ExisteCarrito(int idusuario)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var primerIdUsuario = (from back in db.Carrito
                                               where back.UsuarioId == idusuario
                                               select back).FirstOrDefault();

                return primerIdUsuario != null;
            }
        }

        public void ModificarMonedaCarrito (int idcarro, int monedaid)
        {

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var carro = db.Carrito.Where(s => s.CarritoId == idcarro).FirstOrDefault();
                carro.MonedaId = monedaid;
                db.SaveChanges();
            }

        }

        public CarritoVO DarCarrito(int idcarro)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var carro = db.Carrito.Where(s => s.CarritoId == idcarro).FirstOrDefault();

                return carro.DarCarritoVO();
            }

        }

    }
}
