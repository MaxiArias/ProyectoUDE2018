using System;

namespace LogicaPersistencia
{
    public abstract class Cliente : Usuario
    {
        // Properties
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        // Constructores
        public Cliente(String dir, string tel, int id, string mail, string pass, Boolean activo) : base(id, mail, pass, activo)
        {
            Direccion = dir;
            Telefono = tel;
        }
    }
}
