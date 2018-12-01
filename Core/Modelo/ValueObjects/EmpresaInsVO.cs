using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ValueObjects
{
    public class EmpresaInsVO : ClienteVO
    {
        // Atributes
        //public string rut;
        //public String contacto;

        // Properties
        public string Rut { get; set; }
        public string Contacto { get; set; }


        // Constructores
        public EmpresaInsVO() { }

        public EmpresaInsVO(string ruc, string contact, string dir, string tel, String tipoC, string nom, int id, string mail, string pass, Boolean activo, String tipo) : base(dir, tel, nom, tipoC, id, mail, pass, activo, tipo)
        {
            Rut = ruc;
            Contacto = contact;
        }
    }
}

