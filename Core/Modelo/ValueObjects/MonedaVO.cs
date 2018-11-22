using System;

namespace Modelo.ValueObjects
{
    public class MonedaVO
    {
        // Atributos
        private int idMoneda;

        // Properties
        public int IdMoneda { get { return idMoneda; } }
        public string Abreviatura { get; set;}
        public string Descripcion { get; set;}
        public double Cotizacion { get; set;}

        // Constructores
        public MonedaVO() { }

        public MonedaVO(int idm, string abrev, string desc, double cotiza)
        {
            idMoneda = idm;
            Abreviatura = abrev;
            Descripcion = desc;
            Cotizacion = cotiza;
        }
    }
}
