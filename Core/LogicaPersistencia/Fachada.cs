using LogicaPersistencia.DAO;
using Modelo.ValueObjects;

namespace LogicaPersistencia
{
    public class Fachada : IFachadaWin, IFachadaWeb
    {
        public void InsertarCategoria (CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.InsertarCategoria(catvo);
        }

        public void BorrarCategoria(int catid)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.BorrarCategoria(catid);
        }

        public void ModificarCategoria(CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.ModificarCategoria(catvo);
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

        public void InsertarBackoffice(BackofficeVO bacvo)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.InsertarBackoffice(bacvo);
        }

        public void BorrarBackoffice(int bacid)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.BorrarBackoffice(bacid);
        }

        public void ModificarBackoffice(BackofficeVO bacvo)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            bacdao.ModificarBackoffice(bacvo);
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

        public void ModificarCarrito(CarritoVO carvo)
        {
            CarritoDAO cardao = new CarritoDAO();
            cardao.ModificarCarrito(carvo);
        }

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

        public void ModificarMoneda(MonedaVO monvo)
        {
            MonedaDAO mondao = new MonedaDAO();
            mondao.ModificarMoneda(monvo);
        }

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

        public void ModificarRol(RolVO rolvo)
        {
            RolDAO roldao = new RolDAO();
            roldao.ModificarRol(rolvo);
        }

        public void InsertarUsuario(UsuarioVO usuvo)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            usudao.InsertarUsuario(usuvo);
        }

        public void BorrarUsuario(int usuid)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            usudao.BorrarUsuario(usuid);
        }

        public void ModificarUsuario(UsuarioVO usuvo)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            usudao.ModificarUsuario(usuvo);
        }

    }
}
