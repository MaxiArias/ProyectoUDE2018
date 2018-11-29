using System;
using Modelo.ValueObjects;
using System.Linq;

namespace LogicaPersistencia.DAO
{
    public class UsuarioDAO
    {
        public void InsertarUsuario(UsuarioVO usuvo)
        {
            Usuario ue = new Usuario(usuvo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Usuario.Add(ue);
                db.SaveChanges();
            }
        }

        public void BorrarUsuario(UsuarioVO usuvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(usuvo).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void ModificarUsuario(UsuarioVO usuvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(usuvo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public bool LoginUsuario(string mail, string pass)
        {
            return true;

        }
    }
}
