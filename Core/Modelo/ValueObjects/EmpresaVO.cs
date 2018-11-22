using System;

namespace Modelo.ValueObjects
{
    public class EmpresaVO : ClienteVO
    {

        // Properties
        public string Rut { get; set; }
        public string Contacto { get; set; }
      

        // Constructores
        public EmpresaVO() { }

        public EmpresaVO(string ruc, string contact,string dir, string tel, String tipoC,string nom, int id, string mail, string pass, Boolean activo, String tipo) : base(dir, tel, tipoC,nom, id, mail, pass, activo, tipo)
        {
            Rut = ruc;
            Contacto = contact;
            
            
        }

    }
}
