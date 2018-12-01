using Modelo.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace LogicaPersistencia.DAO
{
    public class ClienteDAO
    {
        public void InsertarCliente (ClienteVO clivo)
        {
            Cliente ce;

            if (clivo.TipoCliente == "Persona")
            {
                ce = new Cliente((PersonaVO)clivo);
            }
            else
            {
                ce = new Cliente((EmpresaVO)clivo);
            }

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                int uid = (from user in db.Usuario
                           where user.UsuarioEmail == clivo.Email
                           select user).First().UsuarioId;
                ce.UsuarioId = uid;
                ce.ClienteDireccion = clivo.Direccion;
                ce.ClienteTelefono = clivo.Telefono;
                ce.ClienteNombre = clivo.Nombre;
                ce.TipoCliente = clivo.TipoCliente;
                ce.ClienteHabilitado = clivo.Activo;
                if (clivo.TipoCliente == "Persona")
                {
                    ce.ClienteCI = ((PersonaVO)clivo).Cedula;
                }
                else
                {
                    ce.EmpresaRUT = ((EmpresaInsVO)clivo).Rut;
                    ce.EmpresaNombreContacto = ((EmpresaInsVO)clivo).Contacto;
                }
                db.Cliente.Add(ce);
                db.SaveChanges();
            }
        }

        public void BorrarCliente(int cliid)
        {

        }

        public void ModificarCliente(ClienteVO clivo)
        {

        }

        public ClienteVO DarCliente(int cliid)
        {
            return null;
        }

        public List<ClienteVO> ListarClientes()

        {
            return null;
        }

    }
}
