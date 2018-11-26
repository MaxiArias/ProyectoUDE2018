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
                //ue.BackOffice = new BackOffice();
                //ue.BackOffice.BackOfficeNombre = ((BackofficeInsVO)(usuvo)).Nombre;
                //ue.BackOffice.RolId = ((BackofficeInsVO)(usuvo)).RolId;
                db.SaveChanges();
            }
        }

        public void BorrarUsuario(int usuid)
        {
            throw new NotImplementedException();
        }

        public void ModificarUsuario(UsuarioVO usuvo)
        {
            throw new NotImplementedException();
        }
    }
}
