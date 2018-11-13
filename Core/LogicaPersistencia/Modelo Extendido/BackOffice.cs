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

        public BackOffice(BackofficeVO vo)
        {
            this.BackOfficeNombre = vo.Nombre;
            this.RolId = Convert.ToInt16(vo.Rol);
            this.UsuarioId = (short) vo.IdUsuario;
        }
    }
}
