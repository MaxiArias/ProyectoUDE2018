using System;

namespace Modelo.ValueObjects
{
    public class ClienteVO : UsuarioVO
    {
        // Atributos
        //private String direccion;
        //private String telefono;
        //private String tipoCliente;
        
        // Properties
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string TipoCliente { get; set; }
        public string Nombre { get; set; }

        // Constructores
        public ClienteVO() { }

        public ClienteVO(String dir, string tel, String tipoC, string nombre, int id, string mail, string pass, Boolean activo, String tipo) : base(id, mail, pass, activo, tipo)
        {
            Direccion = dir;
            Telefono = tel;
            TipoCliente = tipoC;
            Nombre = nombre;
        }
    }
}
