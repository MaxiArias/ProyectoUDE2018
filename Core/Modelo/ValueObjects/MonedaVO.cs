using System;

namespace Modelo.ValueObjects
{
    public class MonedaVO
    {
        // Atributos
        private int idMoneda;
        private String abreviatura;
        private String descripcion;
        private float cotizacion;

        // Properties
        public int IdMoneda { get { return idMoneda; } }
        public string Abreviatura { get { return abreviatura; } }
        public string Descripcion { get { return descripcion; } }
        public float Cotizacion { get { return cotizacion; } }

        // Constructores
        public MonedaVO() { }

        public MonedaVO(int idm, string abrev, string desc, float cotiza)
        {
            idMoneda = idm;
            abreviatura = abrev;
            descripcion = desc;
            cotizacion = cotiza;
        }
    }
}
