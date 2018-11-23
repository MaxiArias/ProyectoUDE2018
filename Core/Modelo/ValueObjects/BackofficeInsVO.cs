using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ValueObjects
{
    public class BackofficeInsVO : UsuarioVO
    {
            // Atributos
            //private String nombre;
            //private int rolid;

            // Properties
            public String Nombre { get; set; }
            public int RolId { get; set; }

        // Constructores
            public BackofficeInsVO () { }

            public BackofficeInsVO(String nom, int rol, int id, string mail, string pass, Boolean activo, String tipo) : base(id, mail, pass, activo, tipo)
            {
                Nombre = nom;
                this.RolId = rol;
            }


    }
}
