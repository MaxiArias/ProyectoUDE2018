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

        public ItemCarrito(ItemCarritoVO vo)
        {
            this.ProductoId = vo.IdProducto;
            this.Producto.ProductoNombre = vo.ProductoNombre; 
            this.Producto.ProductoDescripcion= vo.ProductoDescripcion;
            this.ProductoCantidad = vo.Cantidad;
            this.Carrito.Cliente.UsuarioId = vo.IdCliente;
        }

        public ItemCarritoVO DarItemCarrito()
        {

            return new ItemCarritoVO(ProductoId, Producto.ProductoPrecio, Producto.ProductoNombre, Producto.ProductoDescripcion, ProductoCantidad, Carrito.Cliente.UsuarioId );

        }




    }







}
