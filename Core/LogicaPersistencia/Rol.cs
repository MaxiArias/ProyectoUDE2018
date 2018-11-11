using System;

namespace LogicaPersistencia
{
    public abstract class Rol
    {

        // Atributos
        private int idRol;

        // Properties
        public int IdRol { get { return idRol; } }
        public string Nombre { get; set; }

        // Constructores
        public Rol(int id, string nombre)
        {
            idRol = id;
            Nombre = nombre;
        }


    }
}
