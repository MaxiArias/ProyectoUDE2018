using System;

namespace Modelo.ValueObjects
{
    public class RolVO
    {
        // Atributos
        private int idRol;
        private String nombre;

        // Properties
        public int IdRol { get { return idRol; } }
        public string Nombre { get { return nombre; } }

        // Constructores
        public RolVO() { }

        public RolVO(int idr, string nom)
        {
            idRol = idr;
            nombre = nom;
        }
    }
}