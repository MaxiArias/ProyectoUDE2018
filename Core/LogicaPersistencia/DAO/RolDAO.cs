using Modelo.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace LogicaPersistencia.DAO
{
    public class RolDAO
    {
        public void InsertarRol (RolVO rolvo)
        {
            Rol rol = new Rol(rolvo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Rol.Add(rol);
                db.SaveChanges();
            }
        }

        public void BorrarRol (int rolid)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                //db.Entry(rolvo).State = System.Data.Entity.EntityState.Deleted;
                //db.SaveChanges();
            }


        }

        public void ModificarRol (RolVO rolvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(rolvo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<RolVO> ListarRoles ()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                return db.Rol.ToList().Select(back => back.DarRolVO()).ToList();
            }

        }

    }
}
