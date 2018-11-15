using Modelo.ValueObjects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LogicaPersistencia;
using System.Linq;




namespace LogicaPersistencia.DAO
{
    public class BackofficeDAO
    {

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

        public void BorrarBackoffice (BackofficeVO bkvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(bkvo).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void ModificarBackoffice (BackofficeVO bkvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(bkvo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<UsuarioVO> ListarBackoffice ()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                return db.Usuario.ToList().Select(usu => usu.DarUsuarioVO()).ToList();
            }
        }


        public BackofficeVO DarBackoffice (int id)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                //revisar como es con linq
                BackofficeVO bko = new BackofficeVO(from g in db.Usuario select * where g.UsuarioId= id);

                return bko;
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
