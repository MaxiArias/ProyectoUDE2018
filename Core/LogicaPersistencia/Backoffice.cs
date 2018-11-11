using System;

namespace LogicaPersistencia
{
    public class Backoffice : Usuario
    {
        // Properties
        public String Nombre { get; set; }
        public Enumerados.Rol Rol { get; set; }

        // Constructores
        public Backoffice(String nom, Enumerados.Rol rol, int id, string mail, string pass, Boolean activo) : base(id, mail, pass, activo)
        {
            Nombre = nom;
            Rol = rol ;
        }


    }
}
