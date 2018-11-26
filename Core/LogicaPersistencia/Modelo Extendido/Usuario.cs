using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class Usuario
    {
        public Usuario()
        {

        }

        public Usuario(UsuarioVO vo)
        {
            this.UsuarioActivo = vo.Activo;
            this.UsuarioEmail = vo.Email;
            this.UsuarioContrasenia = vo.Password;
            this.TipoUsuario = vo.TipoUsuario;
        }

        public UsuarioVO DarUsuarioVO()
        {
            return new UsuarioVO(UsuarioId, UsuarioEmail, UsuarioContrasenia, UsuarioActivo, TipoUsuario);
        }

    }
}
