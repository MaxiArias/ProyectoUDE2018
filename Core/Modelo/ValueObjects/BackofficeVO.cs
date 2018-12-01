using System;

namespace Modelo.ValueObjects
{
    public class BackofficeVO : UsuarioVO
    {
        // Atributos
        //private String nombre;
        //private String rol;
        
        // Properties
        public String Nombre { get; set; }
        public String Rol { get; set; }

        // Constructores
        public BackofficeVO() { }

        public BackofficeVO(String nom, String rol, int id, string mail, string pass, Boolean activo, String tipo) : base(id, mail, pass, activo, tipo)
        {
            Nombre = nom;
            this.Rol = rol;
        }

        
    }
}
