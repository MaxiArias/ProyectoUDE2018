using LogicaPersistencia.DAO;
using Modelo.ValueObjects;
using System.Collections.Generic;

namespace LogicaPersistencia
{
    public class Fachada : IFachadaWin, IFachadaWeb
    {
        //metodos de usuario
        public void UsuarioLogin(string mail, string password, out bool existeusr, out bool loginok)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            if (usudao.ExisteUsuario(mail))
            {
                existeusr = true;
                loginok = usudao.LoginUsuario(mail, password);
            }
            else
            {
                existeusr = false;
                loginok = false;
            }
        }

        public void ActivaUsuario(int usrid, bool activo)
        {

            //falta implementar
        }

        //metodos de categoria
        public void InsertarCategoria (CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.InsertarCategoria(catvo);
        }

        public void BorrarCategoria(int catid)
        {
            //validar antes que exista la categoria y que no haya productos asociados a la misma, si hay no se puede borrar.
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.BorrarCategoria(catid);
        }

        public void ModificarDescripcionCategoria(int catid, string desc)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.ModificarDescripcionCategoria(catid, desc);
        }

        public List<CategoriaVO> ListarCategorias()
        {
            CategoriaDAO catdao = new CategoriaDAO();
            return catdao.ListarCategorias();
        }

        public List<CategoriaVO> ListarCategoriasActivas()
        {
            CategoriaDAO catdao = new CategoriaDAO();
            return catdao.ListarCategoriasActivas();
        }

        public CategoriaVO DarCategoria(int catid)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            return catdao.DarCategoria(catid);

        }

        public void ActivarCategoria(int catid, bool activa)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.ActivarCategoria(catid, activa);

        }

        public bool EstadoCategoria(int catid)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            return catdao.EstadoCategoria(catid);

        }

        public void ModificarNombreCategoria(int catid, string nom)
        {
            //validar previamente que exista la categoria
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.ModificarNombreCategoria(catid,nom);

        }

        //metodos de backoffice
        public void InsertarBackoffice(BackofficeInsVO bacvo)
        {
            //validar que no exista antes el usuario
            UsuarioDAO usudao = new UsuarioDAO();
            usudao.InsertarUsuario(bacvo);

            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.InsertarBackoffice(bacvo);
        }

        public void BorrarBackoffice(int bacid)
        {
            //validar antes que exista
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.BorrarBackoffice(bacid);
        }

        public void CambiarRolBackoffice(int bacid, int rolid)
        {
            //validar que exista
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
            mondao.BorrarMoneda(monid);
        }

        public void ModificarMonedaCotizacion(int monedaid, decimal cotiza)
        {
            //que exista
            MonedaDAO mondao = new MonedaDAO();
            mondao.ModificarMonedaCotizacion(monedaid, cotiza);
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

        public List<ProductoVO> ListarProductosHabilitados()
        {
            ProductoDAO prodao = new ProductoDAO();
            return prodao.ListarProductosHabilitados();
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

        public List<ProductoVO> ListarProductosPorCategoriaHabilitados(int catid)
        {
            //validar antes que la categoria exista
            ProductoDAO prodao = new ProductoDAO();
            return prodao.ListarProductoPorCategoriaHabilitado(catid);
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
            roldao.BorrarRol(rolid);
        }

        public void ModificarRol(int rolid, string nom)
        {
            RolDAO roldao = new RolDAO();
            roldao.ModificarRol(rolid,nom);
        }

        public List<RolVO> ListarRoles()
        {
            RolDAO roldao = new RolDAO();
            return roldao.ListarRoles();
        }

        //metodos de cliente
        public void InsertarCliente(ClienteVO clivo)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            usudao.InsertarUsuario(clivo);

            ClienteDAO clidao = new ClienteDAO();
            clidao.InsertarCliente(clivo);
        }

        public void BorrarCliente(int cliid)
        {
            //verificar que exista
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

        //public CarritoVO DarCarritoCliente(int usrid)
        //Aca habria que llamar a ExisteCarritoUsuario
        //public void InsertarCarrito(CarritoVO carvo)
        //{
        //    CarritoDAO cardao = new CarritoDAO();
        //    cardao.InsertarCarrito(carvo);
        //}

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

        //AgregarItemCarrito

        //BorrarItemCarrito

        //DarCarrito

        
    }
}
