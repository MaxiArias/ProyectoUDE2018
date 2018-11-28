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

        public void BorrarUsuario(int usuid)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var usuario = db.Usuario.Where(s => s.UsuarioId == usuid).FirstOrDefault();
                db.Usuario.Remove(usuario);
                db.SaveChanges();
            }
        }

        public void ModificarTipoUsuario(int usuid, string tipo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var usuario = db.Usuario.Where(s => s.UsuarioId == usuid).FirstOrDefault();
                usuario.TipoUsuario = tipo;
                db.SaveChanges();
            }
        }

        public void ActivoUsuario(int usuid, bool activo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var usuario = db.Usuario.Where(s => s.UsuarioId == usuid).FirstOrDefault();
                usuario.UsuarioActivo = activo;
                db.SaveChanges();
            }
        }
        public bool LoginUsuario(string mail, string pass)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var login= (from usuario in db.Usuario
                            where usuario.UsuarioEmail == mail && usuario.UsuarioContrasenia==pass
                            select usuario).FirstOrDefault();

                return login != null;
            }

        }
    }
}
