using System;

namespace Modelo.ValueObjects
{
    public class BackofficeVO : UsuarioVO
    {
        // Atributos
        private String nombre;
        private String rol;
        
        // Properties
        public String Nombre { get { return nombre; } }
        public String Rol { get { return rol; } }

        // Constructores
        public BackofficeVO(String nom, String rol, int id, string mail, string pass, Boolean activo, String tipo) : base(id, mail, pass, activo, tipo)
        {
            nombre = nom;
            this.rol = rol;
        }
    }
}
