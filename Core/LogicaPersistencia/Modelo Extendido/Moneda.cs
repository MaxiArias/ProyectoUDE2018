using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
   public partial class Moneda
    {

        public Moneda(MonedaVO vo)
        {
            this.MonedaId = vo.IdMoneda;
            this.MonedaAbreviatura = vo.Abreviatura;
            this.MonedaCotizacion = vo.Cotizacion;
            this.MonedaDescripción = vo.Descripcion;
        }

        public MonedaVO DarMoneda()
        {

            return new MonedaVO(MonedaId,MonedaAbreviatura, MonedaDescripción, MonedaCotizacion);

        }




    }
}
