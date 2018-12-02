using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public interface IFachadaWeb
    {
        //metodos de usuario
        void UsuarioLogin(string mail, string password, out bool existeusr, out bool loginok);

        //metodos de categoria
        List<CategoriaVO> ListarCategoriasActivas();

        //metodos de producto
        void ModificarStockProducto(int proid, int stock);
        ProductoVO DarProductoPorId(int proid);
        List<ProductoVO> ListarProductosPorCategoria(int catid);
        List<ProductoVO> ListarProductos();

        //metodos de carrito
        //CarritoVO DarCarritoCliente(int usrid) 
        void InsertarCarrito(CarritoVO carvo);
        void BorrarCarrito(int carid);
        void ModificarMonedaCarrito(int carid, int monid);

        //metodos de cliente
        void InsertarCliente(ClienteVO clivo);
        void BorrarCliente(int cliid);
        void ModificarCliente(ClienteVO clivo);
    }
}
