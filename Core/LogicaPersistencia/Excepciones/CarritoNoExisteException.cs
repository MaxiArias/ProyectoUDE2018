﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia.Excepciones
{
    public class CarritoNoExisteException : ApplicationException
    {
        public CarritoNoExisteException(String msg) : base(msg)
        {

        }

        public String DarMensaje()
        {
            return this.Message;
        }
    }
}
