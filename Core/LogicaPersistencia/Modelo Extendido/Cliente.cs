using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class Cliente
    {
        public Cliente(EmpresaVO vo)
        {
            this.EmpresaRUT = vo.Rut;
            this.EmpresaNombreContacto = vo.Contacto;
            this.ClienteNombre= vo.Nombre;
            this.ClienteDireccion = vo.Direccion;
            this.ClienteTelefono = vo.Telefono;

        }

        public EmpresaVO DarEmpresa()
        {

            return new EmpresaVO(EmpresaRUT,EmpresaNombreContacto,ClienteDireccion,ClienteTelefono,TipoCliente,UsuarioId, usua );

        }

        public Cliente(PersonaVO vo)
        {
            this.ClienteDireccion = vo.Direccion;
            this.ClienteNombre = vo.ProductoNombre;
            this.Producto.ProductoDescripcion = vo.ProductoDescripcion;
            this.ProductoCantidad = vo.Cantidad;
            this.Carrito.Cliente.UsuarioId = vo.IdCliente;
        }

        public PersonaVO DarEmpresa()
        {

            return new PersonaVO(ProductoId, Producto.ProductoPrecio, Producto.ProductoNombre, Producto.ProductoDescripcion, ProductoCantidad, Carrito.Cliente.UsuarioId);

        }


    }
}
