using LogicaPersistencia.DAO;
using Modelo.ValueObjects;
using System.Collections.Generic;

namespace LogicaPersistencia
{
    public class Fachada : IFachadaWin, IFachadaWeb
    {
        //metodos de usuario
        public bool UsuarioLogin(string mail,string password)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            //return usudao.UsuarioLogin(mail, password);
            return true;
        }

        //metodos de categoria
        public void InsertarCategoria (CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.InsertarCategoria(catvo);
        }

        public void BorrarCategoria(int catid)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            //catdao.BorrarCategoria(catid);
        }

        public void ModificarCategoria(CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.ModificarCategoria(catvo);
        }

        public List<CategoriaVO> ListarCategorias()
        {
            CategoriaDAO catdao = new CategoriaDAO();
            return catdao.ListarCategorias();
        }

        //metodos de backoffice
        public void InsertarBackoffice(BackofficeInsVO bacvo)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.InsertarBackoffice(bacvo);
        }

        public void BorrarBackoffice(int bacid)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.BorrarBackoffice(bacid);
        }

        public void CambiarRolBackoffice(int bacid, int rolid)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.CambiarRolBackoffice(bacid, rolid);
        }

        public List<BackofficeVO> ListarBackoffice()
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            return bacdao.ListarBackoffice();
        }

        //metodos de moneda
        public void InsertarMoneda(MonedaVO monvo)
        {
            MonedaDAO mondao = new MonedaDAO();
            mondao.InsertarMoneda(monvo);
        }

        public void BorrarMoneda(int monid)
        {
            MonedaDAO mondao = new MonedaDAO();
            //mondao.BorrarMoneda(monid);
        }

        public void ModificarMoneda(MonedaVO monvo)
        {
            MonedaDAO mondao = new MonedaDAO();
            mondao.ModificarMoneda(monvo);
        }

        public List<MonedaVO> ListarMonedas()
        {
            MonedaDAO mondao = new MonedaDAO();
            return mondao.ListarMonedas();
        }

        //metodos de producto
        public void InsertarProducto(ProductoVO provo)
        {
            ProductoDAO prodao = new ProductoDAO();
            prodao.InsertarProducto(provo);
        }

        public void BorrarProducto(int proid)
        {
            ProductoDAO prodao = new ProductoDAO();
            prodao.BorrarProducto(proid);
        }

        public void ModificarProducto(ProductoVO provo)
        {
            ProductoDAO prodao = new ProductoDAO();
            prodao.ModificarProducto(provo);
        }

        public List<ProductoVO> ListarProductos()
        {
            ProductoDAO prodao = new ProductoDAO();
            return prodao.ListarProductos();
        }

        public void ModificarStockProducto(int proid, int stock)
        {
            ProductoDAO prodao = new ProductoDAO();
            prodao.ModificarStockProducto(proid, stock);
        }

        public void HabilitarProducto(int proid, bool habilito)
        {
            ProductoDAO prodao = new ProductoDAO();
            prodao.HabilitarProducto(proid, habilito);
        }

        public ProductoVO DarProductoPorId(int proid)
        {
            ProductoDAO prodao = new ProductoDAO();
            return prodao.DarProductoPorID(proid);
        }

        public List<ProductoVO> ListarProductosPorCategoria(int catid)
        {
            ProductoDAO prodao = new ProductoDAO();
            return prodao.ListarProductoPorCategoria(catid);
        }

        //metodos de rol
        public void InsertarRol(RolVO rolvo)
        {
            RolDAO roldao = new RolDAO();
            roldao.InsertarRol(rolvo);
        }

        public void BorrarRol(int rolid)
        {
            RolDAO roldao = new RolDAO();
            //roldao.BorrarRol(rolid);
        }

        public void ModificarRol(RolVO rolvo)
        {
            RolDAO roldao = new RolDAO();
            roldao.ModificarRol(rolvo);
        }

        public List<RolVO> ListarRoles()
        {
            RolDAO roldao = new RolDAO();
            return roldao.ListarRoles();
        }

        //metodos de cliente
        public void InsertarCliente(ClienteVO clivo)
        {
            ClienteDAO clidao = new ClienteDAO();
            clidao.InsertarCliente(clivo);
        }

        public void BorrarCliente(int cliid)
        {
            ClienteDAO clidao = new ClienteDAO();
            clidao.BorrarCliente(cliid);
        }

        public void ModificarCliente(ClienteVO clivo)
        {
            ClienteDAO clidao = new ClienteDAO();
            clidao.ModificarCliente(clivo);
        }

        public List<ClienteVO> ListarClientes()
        {
            ClienteDAO clidao = new ClienteDAO();
            return clidao.ListarClientes();
        }

        public void InsertarCarrito(CarritoVO carvo)
        {
            CarritoDAO cardao = new CarritoDAO();
            cardao.InsertarCarrito(carvo);
        }

        public void BorrarCarrito(int carid)
        {
            CarritoDAO cardao = new CarritoDAO();
            cardao.BorrarCarrito(carid);
        }

        public void ModificarMonedaCarrito(int carid, int monid)
        {
            CarritoDAO cardao = new CarritoDAO();
            cardao.ModificarMonedaCarrito(carid, monid);
        }
    }
}
