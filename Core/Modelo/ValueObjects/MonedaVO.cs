using System;

namespace Modelo.ValueObjects
{
    public class MonedaVO
    {
        // Atributos
        //private int idMoneda;

        // Properties
        public int IdMoneda { get; set; }
        public string Abreviatura { get; set;}
        public string Descripcion { get; set;}
        public decimal Cotizacion { get; set;}

        // Constructores
        public MonedaVO() { }

        public MonedaVO(int idm, string abrev, string desc, decimal cotiza)
        {
            IdMoneda = idm;
            Abreviatura = abrev;
            Descripcion = desc;
            Cotizacion = cotiza;
        }
    }
}
