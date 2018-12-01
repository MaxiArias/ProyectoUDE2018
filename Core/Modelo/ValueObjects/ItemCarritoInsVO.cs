﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ValueObjects
{
    public class ItemCarritoInsVO
    {
        // Atributos
        //private int idProducto;
        //private int cantidad;
        //private int idCliente;

        // Properties
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int IdCliente { get; set; }

        // Constructores
        public ItemCarritoInsVO()
        {

        }

        public ItemCarritoInsVO(int idp, int cant, int idcliente)
        {
            IdProducto = idp;
            Cantidad = cant;
            IdCliente = idcliente;
        }
    }
}
