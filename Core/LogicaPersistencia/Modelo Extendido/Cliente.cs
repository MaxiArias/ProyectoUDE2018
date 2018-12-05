using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class Cliente
    {
        public Cliente(EmpresaVO vo)
        {
            this.EmpresaRUT = vo.Rut;
            this.EmpresaNombreContacto = vo.Contacto;
            this.ClienteNombre= vo.Nombre;
            this.ClienteDireccion = vo.Direccion;
            this.ClienteTelefono = vo.Telefono;

        }

        public EmpresaVO DarEmpresaVO()
        {

            return new EmpresaVO(this.EmpresaRUT,EmpresaNombreContacto,ClienteDireccion,ClienteTelefono,this.TipoCliente, this.ClienteNombre, this.UsuarioId, this.Usuario.UsuarioEmail,this.Usuario.UsuarioContrasenia, this.Usuario.UsuarioActivo, this.Usuario.TipoUsuario );

        }

        public Cliente(PersonaVO vo)
        {
            this.ClienteCI = vo.Cedula;
            this.ClienteNombre = vo.Nombre;
            this.ClienteDireccion = vo.Direccion;
            this.ClienteTelefono = vo.Telefono;
            this.UsuarioId = vo.IdUsuario;
        }

        public PersonaVO DarPersonaVO()
        {

            return new PersonaVO(this.ClienteCI, this.ClienteNombre, this.ClienteDireccion, this.ClienteTelefono, this.TipoCliente, this.UsuarioId,this.Usuario.UsuarioEmail, this.Usuario.UsuarioContrasenia, this.Usuario.UsuarioActivo, this.Usuario.TipoUsuario);

        }


    }
}
