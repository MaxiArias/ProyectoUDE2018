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
        void UsuarioLoginWEB(string mail, string password);

        //metodos de categoria
        List<CategoriaVO> ListarCategoriasActivas();
        CategoriaVO DarCategoria(int catid);

        //metodos de producto
        void ModificarStockProducto(int proid, int stock);
        ProductoVO DarProductoPorId(int proid);
        List<ProductoVO> ListarProductosPorCategoriaHabilitados(int catid);
        List<ProductoVO> ListarProductosHabilitados();

        //metodos de cliente
        void InsertarCliente(ClienteVO clivo);
        void BorrarCliente(int cliid);
        void ModificarCliente(ClienteVO clivo);

        //metodos de carrito
        CarritoVO DarCarritoCliente(int usrid);
        void BorrarCarrito(int carid);
        void ModificarMonedaCarrito(int carid, int monid);
    }
}
