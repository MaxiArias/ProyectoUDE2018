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
        int DarIdUsuario(string mail);

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

        //metodos de carrito
        CarritoVO DarCarritoCliente(int usrid);
        void BorrarCarrito(int carid);
        void ModificarMonedaCarrito(int carid, int monid);

        //metodos de moneda
        List<MonedaVO> ListarMonedas();

        //metodos de item carrito
        void AgregarItemCarrito(ItemCarritoInsVO item);
        void BorrarItemCarrito(int carroid, int itcid);
    }
}
