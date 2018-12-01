using System;

namespace Modelo.ValueObjects
{
    public class RolVO
    {
        // Atributos
        //private int idRol;
        //private String nombre;

        // Properties
        public int IdRol { get; set; }
        public string Nombre { get; set; }

        // Constructores
        public RolVO() { }

        public RolVO(int idr, string nom)
        {
            IdRol = idr;
            Nombre = nom;
        }
    }
}