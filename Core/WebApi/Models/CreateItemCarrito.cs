using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class CreateItemCarrito
    {
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public int IdCliente { get; set; }

    }
}