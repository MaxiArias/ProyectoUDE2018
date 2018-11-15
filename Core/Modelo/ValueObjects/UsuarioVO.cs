using System;

namespace Modelo.ValueObjects
{
    public class UsuarioVO
    {
        // Atributos
        private int idUsuario;
        private String email;
        private String password;
        private Boolean activo;
        private String tipoUsuario;

        // Properties
        public int IdUsuario { get { return idUsuario; } }
        public String Email { get { return email; } }
        public String Password { get { return password; } }
        public Boolean Activo { get { return activo; } }
        public String TipoUsuario { get { return tipoUsuario; } }

        // Constructores
        public UsuarioVO(int id, String mail, String pass, Boolean activo, String tipo)
        {
            idUsuario = id;
            email = mail;
            password = pass;
            this.activo = activo;
            tipoUsuario = tipo;
        }
    }
}
