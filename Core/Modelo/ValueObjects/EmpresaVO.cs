using System;

namespace Modelo.ValueObjects
{
    public class EmpresaVO : ClienteVO
    {
        // Atributes
        public string rut;
        public String contacto;
        //private string empresaRUT;
        private string empresaNombreContacto;
        private string clienteDireccion;
        private string clienteTelefono;
        private string usuarioEmail;

        // Properties
        public string Rut { get { return rut; } }
        public string Contacto { get { return contacto; } }
      

        // Constructores
        public EmpresaVO() { }

        public EmpresaVO(string ruc, string contact,string dir, string tel, String tipoC, int id, string mail, string pass, Boolean activo, String tipo) : base(dir, tel, tipoC, id, mail, pass, activo, tipo)
        {
            rut = ruc;
            contacto = contact;
            
            
        }

        public EmpresaVO(string empresaRUT, string empresaNombreContacto, string clienteDireccion, string clienteTelefono, string usuarioEmail)
        {
            this.empresaRUT = empresaRUT;
            this.empresaNombreContacto = empresaNombreContacto;
            this.clienteDireccion = clienteDireccion;
            this.clienteTelefono = clienteTelefono;
            this.usuarioEmail = usuarioEmail;
        }
    }
}
