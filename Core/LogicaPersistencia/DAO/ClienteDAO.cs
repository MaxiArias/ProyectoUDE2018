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
            //permite modificar telefono y direccion
        }

        public ClienteVO DarCliente(int cliid)
        {
            return null;
        }

        public List<ClienteVO> ListarClientes()

        {
            return null;
        }

        public bool ExisteCliente(string mail)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var primerClienteEseMail = (from clie in db.Cliente
                                            where clie.Usuario.UsuarioEmail == mail
                                            select clie).FirstOrDefault();

                return primerClienteEseMail != null;
            }
        }

        public bool ExisteCliente(int cliid)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var primerClienteEseMail = (from clie in db.Cliente
                                            where clie.UsuarioId == cliid
                                            select clie).FirstOrDefault();

                return primerClienteEseMail != null;
            }
        }

        public bool ExistePersona(int? cedula)
        {
            if (cedula.HasValue)
            {
                using (TiendaVirtualEntities db = new TiendaVirtualEntities())
                {
                    var existe = (from clie in db.Cliente
                                  where clie.ClienteCI == cedula
                                  select clie).FirstOrDefault();

                    return existe != null;
                }
            }
            else
            {
                return true;
            }
        }

        public ClienteVO DarClientePorEmail(string email)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var cl = (from clie in db.Cliente
                          where clie.Usuario.UsuarioEmail == email
                          select clie).First();

                if (cl.TipoCliente == Enumerados.TipoCliente.Persona.ToString())
                {
                    return cl.DarPersona();
                }
                else
                {
                    return cl.DarEmpresa();
                }
            }
        }

    }
}
