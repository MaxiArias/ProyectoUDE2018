using System;

namespace Modelo.ValueObjects
{
    public class UsuarioVO
    {
        // Atributos
        //private int idUsuario;
        //private String email;
        //private String password;
        //private Boolean activo;
        //private String tipoUsuario;

        // Properties
        public int IdUsuario { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Boolean Activo { get; set; }
        public String TipoUsuario { get; set; }

        // Constructores

        public UsuarioVO() { }

        public UsuarioVO(int id, String mail, String pass, Boolean activo, String tipo)
        {
            IdUsuario = id;
            Email = mail;
            Password = pass;
            this.Activo = activo;
            TipoUsuario = tipo;
        }
    }
}
