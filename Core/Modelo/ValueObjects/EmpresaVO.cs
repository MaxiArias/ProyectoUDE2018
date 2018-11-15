using System;

namespace Modelo.ValueObjects
{
    public class EmpresaVO : ClienteVO
    {
        // Atributes
        public int rut;
        public String contacto;
        public String razonSocial;

        // Properties
        public int Rut { get { return rut; } }
        public string Contacto { get { return contacto; } }
        public string RazonSocial { get { return razonSocial; } }

        // Constructores
        public EmpresaVO(int ruc, string contact, string razon, string dir, string tel, String tipoC, int id, string mail, string pass, Boolean activo, String tipo) : base(dir, tel, tipoC, id, mail, pass, activo, tipo)
        {
            rut = ruc;
            contacto = contact;
            razonSocial = razon;
        }
    }
}
