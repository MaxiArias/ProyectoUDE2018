using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class ItemCarrito
    {

        public ItemCarrito(ItemCarritoInsVO vo)
        {
            this.ProductoId = vo.IdProducto;
             this.ProductoCantidad = vo.Cantidad;
            this.CarritoId = vo.IdCarrito;
        }

        public ItemCarritoVO DarItemCarrito()
        {

            return new ItemCarritoVO(ProductoId, Producto.ProductoPrecio, Producto.ProductoNombre, Producto.ProductoDescripcion, ProductoCantidad, Carrito.Cliente.UsuarioId );

        }




    }







}
