using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia.Excepciones
{
    public class LoginIncorrectoException : ApplicationException
    {
        //private String email;

        public LoginIncorrectoException(String msg) : base(msg)
        {
            //this.email = email;
        }

        public String DarMensaje()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append(this.Message);
            //sb.Append(email);
            //return sb.ToString();
            return this.Message;
        }
    }
}
