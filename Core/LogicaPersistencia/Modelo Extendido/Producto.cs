using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class Producto
    {
        public Producto(ProductoVO vo)
        {
            this.ProductoId = vo.IdProducto;
            this.ProductoNombre = vo.Nombre;
            this.ProductoDescripcion = vo.Descripcion;
            this.ProductoFoto = vo.Foto;
            this.ProductoPrecio = vo.Precio;
            this.ProductoFechaAlta = vo.FechaAlta;
            this.ProductoStock = vo.Stock;
            this.ProductoHabilitado = vo.Habilitado;
            this.CategoriaId = vo.IdCategoria;
            
        }

        public ProductoVO DarProducto()
        {

            return new ProductoVO(ProductoId, ProductoNombre, ProductoDescripcion, ProductoFoto, ProductoPrecio, ProductoStock,ProductoFechaAlta, ProductoHabilitado, CategoriaId);

        }


    }
}
