using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ValueObjects
{
    public class ItemCarritoInsVO
    {
        // Atributos
        private int idProducto;
        private int cantidad;
        private int idCliente;

        // Properties
        public int IdProducto { get { return idProducto; } }
        public int Cantidad { get { return cantidad; } }
        public int IdCliente { get { return idCliente; } }

        // Constructores

        public ItemCarritoInsVO()
        {
        }
        public ItemCarritoInsVO(int idp, int cant, int idcliente)
        {
            idProducto = idp;
            cantidad = cant;
            idCliente = idcliente;
        }
    }
}
