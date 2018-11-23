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

        public void BorrarMoneda(MonedaVO monvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(monvo).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void ModificarMoneda(MonedaVO monvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(monvo).State = System.Data.Entity.EntityState.Modified;
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
