using Modelo.ValueObjects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LogicaPersistencia;
using System.Linq;




namespace LogicaPersistencia.DAO
{
    public class BackofficeDAO
    {

        //BackOffice BK = new BackOffice();

        public void InsertarBackoffice (BackofficeVO bkvo)
        {
            BackOffice be = new BackOffice(bkvo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.BackOffice.Add(be);
                db.SaveChanges();
            }
            
            // Inserta un nuevo BackOffice
            //INSERT INTO BackOffice (UsuarioId,BackOfficeNombre,RolId) VALUES (bkvo.id, bkvo.nombre, bkvo.rol)
        }

        public void BorrarBackoffice (int bkid)
        {
            //Elimina el Backoffice del que se pasa su id
            //DELETE FROM BackOffice WHERE UsuarioId=bkid
        }

        public void ModificarBackoffice (BackofficeVO bkvo)
        {
            //Modifica los datos del Backoffice dado, a excepción del id.
            // UPDATE BackOffice SET BackOfficeNombre=bkvo.Nombre,RolId=bkvo.Rol WHERE UsuarioId=bkvo.id
        }

        public List<UsuarioVO> ListarBackoffice ()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                return db.Usuario.ToList().Select(usu => usu.DarUsuarioVO()).ToList();
            }
        }

        public List<BackofficeVO> ListarBackofficeRol (int bkrol)
        {
            // Lista los Backoffice que poseen un determinado rol
            // SELECT * FROM BackOffice WHERE RolId=bkrol
             return null;
        }
    }
}
