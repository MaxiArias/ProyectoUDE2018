using System;
using System.Collections.Generic;
using System.Linq;
using Modelo.ValueObjects;

namespace LogicaPersistencia.DAO
{
    public class MonedaDAO
    {
        public void InsertarMoneda(MonedaVO monvo)
        {
            Moneda mo = new Moneda(monvo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Moneda.Add(mo);
                db.SaveChanges();
            }
        }

        public void BorrarMoneda(int monedaid)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var moid = db.Moneda.Where(s => s.MonedaId == monedaid).FirstOrDefault();
                db.Moneda.Remove(moid);
                db.SaveChanges();
            }
        }

        public void ModificarMonedaCotizacion(int monedaid, double cotiza)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var moid = db.Moneda.Where(s => s.MonedaId == monedaid).FirstOrDefault();
                moid.MonedaCotizacion = cotiza;
                db.SaveChanges();
            }
        }

        public List<MonedaVO> ListarMonedas()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                return db.Moneda.ToList().Select(back => back.DarMonedaVO()).ToList();
            }
        }
    }
}
