using System;

namespace Modelo.ValueObjects
{
    public class PersonaVO : ClienteVO
    {
        // Atributos
        private int cedula;
        private String nombre; 

        // Properties
        public int Cedula { get { return cedula; } }
        public string Nombre { get { return nombre; } }

        // Constructores
        public PersonaVO() { }

        public PersonaVO(int ci, string nom, String dir, string tel, String tipoC, int id, string mail, string pass, Boolean activo, String tipo) : base(dir, tel, tipoC, id, mail, pass, activo, tipo)
        {
            cedula = ci;
            nombre = nom;
        }
    }
}
