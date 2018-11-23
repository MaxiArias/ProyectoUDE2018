using Modelo.ValueObjects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LogicaPersistencia;
using System.Linq;




namespace LogicaPersistencia.DAO
{
    public class BackofficeDAO
    {

        public void InsertarBackoffice (BackofficeInsVO bkvo)
        {
            BackOffice be = new BackOffice(bkvo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.BackOffice.Add(be);
                db.SaveChanges();
            }
            
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

        public List<BackofficeVO> ListarBackoffice ()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                return db.BackOffice.ToList().Select(back => back.DarBackofficeVO()).ToList();
            }
        }


       public bool ExisteBackoffice(string mail)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                
                var primerBackOfficeEseMail = (from back in db.BackOffice
                                               where back.Usuario.UsuarioEmail == mail
                                                select back).FirstOrDefault();

              return primerBackOfficeEseMail != null;               
            }
        }

    }
}
