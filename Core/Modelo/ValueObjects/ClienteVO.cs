using System;

namespace Modelo.ValueObjects
{
    public class ClienteVO : UsuarioVO
    {
        // Atributos
        private String direccion;
        private String telefono;
        private String tipoCliente;
        
        // Properties
        public string Direccion { get { return direccion; } }
        public string Telefono { get { return telefono; } }
        public string TipoCliente { get { return tipoCliente; } }

        // Constructores
        public ClienteVO() { }

        public ClienteVO(String dir, string tel, String tipoC, int id, string mail, string pass, Boolean activo, String tipo) : base(id, mail, pass, activo, tipo)
        {
            direccion = dir;
            telefono = tel;
            tipoCliente = tipoC;
        }
    }
}
