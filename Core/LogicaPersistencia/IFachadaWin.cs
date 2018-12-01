using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public interface IFachadaWin
    {
        //metodos de usuario
        bool UsuarioLogin(string mail, string password);

        //metodos de categoria
        void InsertarCategoria(CategoriaVO catvo);
        void BorrarCategoria(int catid);
        void ModificarCategoria(CategoriaVO catvo);
        List<CategoriaVO> ListarCategorias();

        //metodos de backoffice
        void InsertarBackoffice(BackofficeInsVO bacvo);
        void BorrarBackoffice(int bacid);
        void CambiarRolBackoffice(int bacid, int rolid);
        List<BackofficeVO> ListarBackoffice();

        //metodos de moneda
        void InsertarMoneda(MonedaVO monvo);
        void BorrarMoneda(int monid);
        void ModificarMoneda(MonedaVO monvo);
        List<MonedaVO> ListarMonedas();

        //metodos de producto
        void InsertarProducto(ProductoVO provo);
        void BorrarProducto(int proid);
        void ModificarProducto(ProductoVO provo);
        void ModificarStockProducto(int prodid, int stock);
        void HabilitarProducto(int proid, Boolean habilito);
        List<ProductoVO> ListarProductos();

        //metodos de rol
        void InsertarRol(RolVO rolvo);
        void BorrarRol(int rolid);
        void ModificarRol(RolVO rolvo);
        List<RolVO> ListarRoles();

        //metodos de cliente
        void BorrarCliente(int cliid);
        List<ClienteVO> ListarClientes();
    }
} 
