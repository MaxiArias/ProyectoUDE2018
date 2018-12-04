using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia.DAO
{
    public class ItemCarritoDAO
    {
        public void InsertarItemCarrito(ItemCarritoVO carivo)
        {
            ItemCarrito ica = new ItemCarrito(carivo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.ItemCarrito.Add(ica);
                db.SaveChanges();
            }
        }

        public void BorrarItemCarrito(int idproducto)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var icarro = db.ItemCarrito.Where(s => s.ProductoId == idproducto).FirstOrDefault();
                db.ItemCarrito.Remove(icarro);
                db.SaveChanges();
            }
        }

        public bool ExisteItemCarrito(int idproducto)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var primerIdProducto = (from back in db.ItemCarrito
                                       where back.ProductoId== idproducto
                                       select back).FirstOrDefault();

                return primerIdProducto != null;
            }
        }

        public void AgregarItemCarrito(int idproducto)
        {

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var icarro = db.ItemCarrito.Where(s => s.ProductoId == idproducto).FirstOrDefault();
                if (icarro != null)
                {
                    icarro.ProductoCantidad++;
                    db.SaveChanges();
                }
            }

        }

        public void SacarItemCarrito(int idproducto)
        {

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var icarro = db.ItemCarrito.Where(s => s.ProductoId == idproducto).FirstOrDefault();
                if (icarro != null && icarro.ProductoCantidad>1)
                {
                    icarro.ProductoCantidad--;
                    db.SaveChanges();
                }
                else
                    if (icarro != null && icarro.ProductoCantidad==1)
                    {
                        db.ItemCarrito.Remove(icarro);
                        db.SaveChanges();

                    }


            }

        }

    }
}
