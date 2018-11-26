using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class BackOffice
    {
        public BackOffice()
        {

        }

        public BackOffice(BackofficeInsVO vo)
        {
            this.BackOfficeNombre = vo.Nombre;
            this.RolId = vo.RolId;
        }

        public BackofficeVO DarBackofficeVO()
        {
            
            return new BackofficeVO(BackOfficeNombre, Rol.RolNombre, Usuario.UsuarioId, Usuario.UsuarioEmail, Usuario.UsuarioContrasenia, Usuario.UsuarioActivo, Usuario.TipoUsuario);

        }
    }
}
