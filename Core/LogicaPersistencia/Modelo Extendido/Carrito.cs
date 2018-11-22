using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class Carrito
    {
        /*public Carrito()
        {

        }*/

        public Carrito(CarritoVO vo)
        {
            this.CarritoId = vo.IdCarrito;
            this.UsuarioId = vo.IdCliente;
            this.MonedaId = vo.IdMoneda;
            this.CarritoFechaCreacion = vo.FechaCreacion;
        }

        public CarritoVO DarCarritoVO()
        {

            return new CarritoVO(CarritoId, UsuarioId, CarritoFechaCreacion, MonedaId);

        }


    }
}
