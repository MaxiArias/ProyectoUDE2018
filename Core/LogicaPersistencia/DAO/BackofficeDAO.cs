using Modelo.ValueObjects;
using System.Collections.Generic;

namespace LogicaPersistencia.DAO
{
    public class BackofficeDAO
    {

        public void InsertarBackoffice (BackofficeVO bkvo)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection myConnection = null;
            SqlDataReader myReader = null;
            
            
            
            
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

        public List<BackofficeVO> ListarBackoffice ()
        {
            // Lista todos los registros de BackOffice
            // SELECT * FROM BackOffice
            return null;
        }

        public List<BackofficeVO> ListarBackofficeRol (int bkrol)
        {
            // Lista los Backoffice que poseen un determinado rol
            // SELECT * FROM BackOffice WHERE RolId=bkrol
             return null;
        }
    }
}
