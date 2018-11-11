using System;

namespace LogicaPersistencia
{
    public abstract class Usuario
    {

        // Atributos
        private int idUsuario;

        // Properties
        public int IdUsuario { get { return idUsuario; } }
        public string Email { get; set; }
        public string Password { get; set; }
        public Boolean Activo { get; set; }

        // Constructores
        public Usuario(int id, string mail, string pass, Boolean activo)
        {
            idUsuario = id;
            Email = mail;
            Password = pass;
            Activo = activo;
        }


    }
}
