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
                var rol = db.Rol.Where(s => s.RolId == rolid).FirstOrDefault();
                db.Rol.Remove(rol);
                db.SaveChanges();
            }


        }

        public void ModificarRol (int rolid, string nom)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var rol = db.Rol.Where(s => s.RolId == rolid ).FirstOrDefault();
                rol.RolNombre = nom;
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
