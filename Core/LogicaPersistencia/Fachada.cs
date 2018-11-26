using LogicaPersistencia.DAO;
using Modelo.ValueObjects;
using System.Collections.Generic;

namespace LogicaPersistencia
{
    public class Fachada : IFachadaWin, IFachadaWeb
    {
        public bool UsuarioLogin(string mail,string password)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            //return usudao.UsuarioLogin(mail, password);
            return true;
        }

        public void InsertarCategoria (CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.InsertarCategoria(catvo);
        }

        public void BorrarCategoria(CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.BorrarCategoria(catvo);
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

        public void InsertarBackoffice(BackofficeInsVO bacvo)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.InsertarBackoffice(bacvo);
        }

        public void BorrarBackoffice(BackofficeVO bacvo)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.BorrarBackoffice(bacvo);
        }

        public void ModificarBackoffice(BackofficeVO bacvo)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.ModificarBackoffice(bacvo);
        }

        public List<BackofficeVO> ListarBackoffice()
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            return bacdao.ListarBackoffice();
        }

        public void InsertarMoneda(MonedaVO monvo)
        {
            MonedaDAO mondao = new MonedaDAO();
            mondao.InsertarMoneda(monvo);
        }

        public void BorrarMoneda(MonedaVO monvo)
        {
            MonedaDAO mondao = new MonedaDAO();
            mondao.BorrarMoneda(monvo);
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

        public void InsertarProducto(ProductoVO provo)
        {
            ProductoDAO prodao = new ProductoDAO();
            prodao.InsertarProducto(provo);
        }

        public void BorrarProducto(ProductoVO provo)
        {
            ProductoDAO prodao = new ProductoDAO();
            prodao.BorrarProducto(provo);
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

        public void InsertarRol(RolVO rolvo)
        {
            RolDAO roldao = new RolDAO();
            roldao.InsertarRol(rolvo);
        }

        public void BorrarRol(RolVO rolvo)
        {
            RolDAO roldao = new RolDAO();
            roldao.BorrarRol(rolvo);
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

        //public void InsertarCarrito(CarritoVO carvo)
        //{
        //    CarritoDAO cardao = new CarritoDAO();
        //    cardao.InsertarCarrito(carvo);
        //}

        //public void BorrarCarrito(int carid)
        //{
        //    CarritoDAO cardao = new CarritoDAO();
        //    cardao.BorrarCarrito(carid);
        //}

        //public void ModificarCarrito(CarritoVO carvo)
        //{
        //    CarritoDAO cardao = new CarritoDAO();
        //    cardao.ModificarCarrito(carvo);
        //}

        //public void InsertarUsuario(UsuarioVO usuvo)
        //{
        //    UsuarioDAO usudao = new UsuarioDAO();
        //    usudao.InsertarUsuario(usuvo);
        //}

        //public void BorrarUsuario(UsuarioVO usuvo)
        //{
        //    UsuarioDAO usudao = new UsuarioDAO();
        //    usudao.BorrarUsuario(usuvo);
        //}

        //public void ModificarUsuario(UsuarioVO usuvo)
        //{
        //    UsuarioDAO usudao = new UsuarioDAO();
        //    usudao.ModificarUsuario(usuvo);
        //}

        //public List<UsuarioVO> ListarUsuarios()
        //{
        //    UsuarioDAO usudao = new UsuarioDAO();
        //    //return usudao.ListarUsuarios();
        //    return null;
        //}

    }
}
