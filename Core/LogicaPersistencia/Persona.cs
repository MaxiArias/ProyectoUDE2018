using System;

namespace LogicaPersistencia
{
    public class Persona : Cliente
    {
        // Atributes
        private int cedula;

        // Properties
        public int Cedula { get { return cedula; } }
        public string Nombre { get; set; }

        // Constructores
        public Persona(int ci, string nom, String dir, string tel, int id, string mail, string pass, Boolean activo) : base(dir, tel, id, mail, pass, activo)
        {
            cedula = ci;
            Nombre = nom;
        }
    }
}
