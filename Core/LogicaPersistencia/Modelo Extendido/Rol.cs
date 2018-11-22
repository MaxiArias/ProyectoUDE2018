using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class Rol
    {

        public Rol(RolVO vo)
        {
            this.RolId = vo.IdRol;
            this.RolNombre = vo.Nombre;
        }

        public RolVO DarRol()
        {

            return new RolVO(RolId, RolNombre);

        }



    }
}
