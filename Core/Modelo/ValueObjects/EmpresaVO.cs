using System;

namespace Modelo.ValueObjects
{
    public class EmpresaVO : ClienteVO
    {
        // Atributes
        public string rut;
        public String contacto;

        // Properties
        public string Rut { get { return rut; } }
        public string Contacto { get { return contacto; } }
      

        // Constructores
        public EmpresaVO() { }

        public EmpresaVO(string ruc, string contact,string dir, string tel, String tipoC, int id, string mail, string pass, Boolean activo, String tipo) : base(dir, tel, tipoC, id, mail, pass, activo, tipo)
        {
            rut = ruc;
            contacto = contact;
            razonSocial = razon;
        }
    }
}
