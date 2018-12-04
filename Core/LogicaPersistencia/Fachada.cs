using LogicaPersistencia.DAO;
using Modelo.ValueObjects;
using System.Collections.Generic;
using LogicaPersistencia.Excepciones;

namespace LogicaPersistencia
{
    public class Fachada : IFachadaWin, IFachadaWeb
    {
        //metodos de usuario
        public void UsuarioLoginWIN(string mail, string password)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            if (usudao.ExisteUsuario(mail))
            {
                if (usudao.LoginUsuario(mail, password))
                {
                    BackofficeDAO bacdao = new BackofficeDAO();
                    if (bacdao.ExisteBackoffice(mail))
                    {
                        if (!bacdao.DarBackofficePorEmail(mail).Activo)
                        {
                            throw new UsuarioNoHabilitadoException("Usuario no habilitado");
                        }
                    }
                    else
                    {
                        throw new UsuarioNoHabilitadoException("Perfil de usuario no habilitado");
                    }
                }
                else
                {
                    throw new LoginIncorrectoException("Contraseña incorrecta");
                }
            }
            else
            {
                throw new UsuarioNoExisteException("Usuario no existe, verifique email");
            }
        }

        public void UsuarioLoginWEB(string mail, string password)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            if (usudao.ExisteUsuario(mail))
            {
                if (usudao.LoginUsuario(mail, password))
                {
                    ClienteDAO clidao = new ClienteDAO();
                    if (clidao.ExisteCliente(mail))
                    {
                        if (!clidao.DarClientePorEmail(mail).Activo)
                        {
                            throw new UsuarioNoHabilitadoException("Usuario no habilitado");
                        }
                    }
                    else
                    {
                        throw new UsuarioNoHabilitadoException("Perfil de usuario no habilitado");
                    }
                }
                else
                {
                    throw new LoginIncorrectoException("Contraseña incorrecta");
                }
            }
            else
            {
                throw new UsuarioNoExisteException("Usuario no existe, verifique email");
            }
        }

        public void ActivaUsuario(int usrid, bool activo)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            if (usudao.ExisteUsuario(usrid))
            {
                usudao.ActivoUsuario(usrid, activo);
            }
            else
            {
                throw new UsuarioNoExisteException("Usuario no existe");
            }   
        }

        //metodos de categoria
        public void InsertarCategoria (CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            if (catdao.ExisteCategoria(catvo.Nombre))
            {
                throw new CategoriaYaExisteException("Ya existe una categoria con ese nombre");
            }
            else
            {
                catdao.InsertarCategoria(catvo);
            }       
        }

        public void BorrarCategoria(int catid)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            if (catdao.ExisteCategoria(catid))
            {
                ProductoDAO prodao = new ProductoDAO();
                if (prodao.ListarProductoPorCategoria(catid).Count == 0)
                {
                    catdao.BorrarCategoria(catid);
                }
                else
                {
                    throw new CategoriaConProductosAsociadosException("La categoria cuenta con productos asociados");
                }    
            }
            else
            {
                throw new CategoriaNoExisteException("No existe una categoria con ese id");
            }     
        }

        public void ModificarDescripcionCategoria(int catid, string desc)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            if (catdao.ExisteCategoria(catid))
            {
                catdao.ModificarDescripcionCategoria(catid, desc);
            }
            else
            {
                throw new CategoriaNoExisteException("No existe una categoria con ese id");
            }      
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
            if (catdao.ExisteCategoria(catid))
            {
                return catdao.DarCategoria(catid);
            }
            else
            {
                throw new CategoriaNoExisteException("No existe una categoria con ese id");
            }   
        }

        public void ActivarCategoria(int catid, bool activa)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            if (catdao.ExisteCategoria(catid))
            {
                catdao.ActivarCategoria(catid, activa);
            }
            else
            {
                throw new CategoriaNoExisteException("No existe una categoria con ese id");
            }   
        }

        public bool EstadoCategoria(int catid)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            if (catdao.ExisteCategoria(catid))
            {
                return catdao.EstadoCategoria(catid);
            }
            else
            {
                throw new CategoriaNoExisteException("No existe una categoria con ese id");
            }   
        }

        public void ModificarNombreCategoria(int catid, string nom)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            if (catdao.ExisteCategoria(catid))
            {
                if (catdao.ExisteCategoria(nom))
                {
                    throw new CategoriaYaExisteException("Ya existe una categoria con ese nombre");
                }
                else
                {
                    catdao.ModificarNombreCategoria(catid, nom);
                }
            }
            else
            {
                throw new CategoriaNoExisteException("No existe una categoria con ese id");
            }
        }

        //metodos de backoffice
        public void InsertarBackoffice(BackofficeInsVO bacvo)
        {
            UsuarioDAO usudao = new UsuarioDAO();
            if (usudao.ExisteUsuario(bacvo.Email))
            {
                throw new UsuarioYaExisteException("Ya existe un usuario con ese email");
            }
            else
            {
                usudao.InsertarUsuario(bacvo);
                BackofficeDAO bacdao = new BackofficeDAO();
                bacdao.InsertarBackoffice(bacvo);
            }
        }

        public void BorrarBackoffice(int bacid)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            if (bacdao.ExisteBackoffice(bacid))
            {
                bacdao.BorrarBackoffice(bacid);
            }
            else
            {
                throw new BackofficeNoExisteException("No existe un usuario de backoffice con ese id");
            }
        }

        public void CambiarRolBackoffice(int bacid, int rolid)
        {
            BackofficeDAO bacdao = new BackofficeDAO();
            if (bacdao.ExisteBackoffice(bacid))
            {
                RolDAO roldao = new RolDAO();
                if (roldao.ExisteRol(rolid))
                {
                    bacdao.CambiarRolBackoffice(bacid, rolid);
                }
                else
                {
                    throw new RolNoExisteException("No existe un rol con ese id");
                }
            }
            else
            {
                throw new BackofficeNoExisteException("No existe un usuario de backoffice con ese id");
            }
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
            if (mondao.ExisteMoneda(monvo.Descripcion))
            {
                throw new MonedaYaExisteException("Ya existe una moneda con esa descripcion");
            }
            else
            {
                mondao.InsertarMoneda(monvo);
            }
        }

        public void BorrarMoneda(int monid)
        {
            MonedaDAO mondao = new MonedaDAO();
            if (mondao.ExisteMoneda(monid))
            {
                mondao.BorrarMoneda(monid);
            }
            else
            {
                throw new MonedaNoExisteException("No existe una moneda con ese id");
            }
        }

        public void ModificarMonedaCotizacion(int monedaid, decimal cotiza)
        {
            MonedaDAO mondao = new MonedaDAO();
            if (mondao.ExisteMoneda(monedaid))
            {
                mondao.ModificarMonedaCotizacion(monedaid, cotiza);
            }
            else
            {
                throw new MonedaNoExisteException("No existe una moneda con ese id");
            }
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
            if (prodao.ExisteProducto(provo.Nombre))
            {
                throw new ProductoYaExisteException("Ya existe un producto con ese nombre");
            }
            else
            {
                prodao.InsertarProducto(provo);
            }
        }

        public void BorrarProducto(int proid)
        {
            ProductoDAO prodao = new ProductoDAO();
            if (prodao.ExisteProducto(proid))
            {
                prodao.BorrarProducto(proid);
            }
            else
            {
                throw new ProductoNoExisteException("No existe un producto con ese id");
            }
        }

        public void ModificarProducto(ProductoVO provo)
        {
            ProductoDAO prodao = new ProductoDAO();
            if (prodao.ExisteProducto(provo.IdProducto))
            {
                if (prodao.ExisteProducto(provo.IdProducto, provo.Nombre))
                {
                    throw new ProductoYaExisteException("Ya existe un producto con ese nombre");
                }
                else
                {
                    prodao.ModificarProducto(provo);
                }
            }
            else
            {
                throw new ProductoNoExisteException("No existe un producto con ese id");
            }
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
            if (prodao.ExisteProducto(proid))
            {
                if (stock >= 0)
                {
                    prodao.ModificarStockProducto(proid, stock);
                }
                else
                {
                    throw new StockNegativoException("El stock no puede ser negativo");
                }
            }
            else
            {
                throw new ProductoNoExisteException("No existe un producto con ese id");
            }
        }

        public void HabilitarProducto(int proid, bool habilito)
        {
            ProductoDAO prodao = new ProductoDAO();
            if (prodao.ExisteProducto(proid))
            {
                prodao.HabilitarProducto(proid, habilito);
            }
            else
            {
                throw new ProductoNoExisteException("No existe un producto con ese id");
            }
        }

        public ProductoVO DarProductoPorId(int proid)
        {
            ProductoDAO prodao = new ProductoDAO();
            if (prodao.ExisteProducto(proid))
            {
                return prodao.DarProductoPorID(proid);
            }
            else
            {
                throw new ProductoNoExisteException("No existe un producto con ese id");
            }
        }

        public List<ProductoVO> ListarProductosPorCategoria(int catid)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            if (catdao.ExisteCategoria(catid))
            {
                ProductoDAO prodao = new ProductoDAO();
                return prodao.ListarProductoPorCategoria(catid);
            }
            else
            {
                throw new CategoriaNoExisteException("No existe una categoria con ese id");
            }
        }

        public List<ProductoVO> ListarProductosPorCategoriaHabilitados(int catid)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            if (catdao.ExisteCategoria(catid))
            {
                if (catdao.EstadoCategoria(catid))
                {
                    ProductoDAO prodao = new ProductoDAO();
                    return prodao.ListarProductoPorCategoriaHabilitado(catid);
                }
                else
                {
                    throw new CategoriaNoHabilitadaException("Categoria no habilitada");
                }
            }
            else
            {
                throw new CategoriaNoExisteException("No existe una categoria con ese id");
            }
        }

        //metodos de rol
        public void InsertarRol(RolVO rolvo)
        {
            RolDAO roldao = new RolDAO();
            if (roldao.ExisteRol(rolvo.Nombre))
            {
                throw new RolYaExisteException("Ya existe un rol con ese nombre");
            }
            else
            {
                roldao.InsertarRol(rolvo);
            }
        }

        public void BorrarRol(int rolid)
        {
            RolDAO roldao = new RolDAO();
            if (roldao.ExisteRol(rolid))
            {
                roldao.BorrarRol(rolid);
            }
            else
            {
                throw new RolNoExisteException("No existe un rol con ese id");
            }
        }

        public void ModificarRol(int rolid, string nom)
        {
            RolDAO roldao = new RolDAO();
            if (roldao.ExisteRol(rolid))
            {
                if (roldao.ExisteRol(nom))
                {
                    throw new RolYaExisteException("Ya existe un rol con ese nombre");
                }
                else
                {
                    roldao.ModificarRol(rolid, nom);
                }
            }
            else
            {
                throw new RolNoExisteException("No existe un rol con ese id");
            }
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
            if (usudao.ExisteUsuario(clivo.Email))
            {
                throw new UsuarioYaExisteException("Ya existe un usuario con ese email");
            }
            else
            {
                ClienteDAO clidao = new ClienteDAO();
                if (clivo.TipoCliente == Enumerados.TipoCliente.Persona.ToString())
                {
                    if (clidao.ExistePersona(((PersonaVO)clivo).Cedula))
                    {
                        throw new PersonaYaExisteException("Ya existe una persona con esa cedula");
                    }
                }
                usudao.InsertarUsuario(clivo);
                clidao.InsertarCliente(clivo);
            }
        }

        public void BorrarCliente(int cliid)
        {
            ClienteDAO clidao = new ClienteDAO();
            if (clidao.ExisteCliente(cliid))
            {
                clidao.BorrarCliente(cliid);
            }
            else
            {
                throw new ClienteNoExisteException("No existe un cliente con ese id");
            }
        }

        public void ModificarCliente(ClienteVO clivo)
        {
            ClienteDAO clidao = new ClienteDAO();
            if (clidao.ExisteCliente(clivo.IdUsuario))
            {
                clidao.ModificarCliente(clivo);
            }
            else
            {
                throw new ClienteNoExisteException("No existe un cliente con ese id");
            }
        }

        public List<ClienteVO> ListarClientes()
        {
            ClienteDAO clidao = new ClienteDAO();
            return clidao.ListarClientes();
        }

        //metodos de carrito
        public CarritoVO DarCarritoCliente(int usrid)
        {
            ClienteDAO clidao = new ClienteDAO();
            if (clidao.ExisteCliente(usrid))
            {
                CarritoDAO cardao = new CarritoDAO();
                if (!cardao.ExisteCarrito(usrid))
                {
                    MonedaDAO mondao = new MonedaDAO();
                    int monedaPorDefecto = mondao.ListarMonedas()[0].IdMoneda;
                    CarritoVO carvo = new CarritoVO()
                    {
                        IdCliente = usrid,
                        FechaCreacion = System.DateTime.Today,
                        IdMoneda = monedaPorDefecto
                    };
                    cardao.InsertarCarrito(carvo);
                }  
                return cardao.DarCarrito(usrid);
            }
            else
            {
                throw new ClienteNoExisteException("No existe un cliente con ese id");
            }
        }

        public void BorrarCarrito(int cliid)
        {
            ClienteDAO clidao=new ClienteDAO();
            if (clidao.ExisteCliente(cliid))
            {
                CarritoDAO cardao = new CarritoDAO();
                if (cardao.ExisteCarrito(cliid))
                {
                    CarritoVO carvo = cardao.DarCarrito(cliid);
                    cardao.BorrarCarrito(carvo.IdCarrito);
                }
                else
                {
                    throw new CarritoNoExisteException("El cliente no tiene carrito asociado");
                }
            }
            throw new ClienteNoExisteException("No existe un cliente con ese id");
        }

        public void ModificarMonedaCarrito(int cliid, int monid)
        {
            ClienteDAO clidao = new ClienteDAO();
            if (clidao.ExisteCliente(cliid))
            {
                CarritoDAO cardao = new CarritoDAO();
                if (cardao.ExisteCarrito(cliid))
                {
                    MonedaDAO mondao = new MonedaDAO();
                    if (mondao.ExisteMoneda(monid))
                    {
                        CarritoVO carvo = cardao.DarCarrito(cliid);
                        cardao.ModificarMonedaCarrito(carvo.IdCarrito, monid);
                    }
                    else
                    {
                        throw new MonedaNoExisteException("No existe una moneda con ese id");
                    }
                }
                else
                {
                    throw new CarritoNoExisteException("El cliente no tiene carrito asociado");
                }
            }
            throw new ClienteNoExisteException("No existe un cliente con ese id");
        }

        //metodos de item carrito
        public void AgregarItemCarrito(int cliid, ItemCarritoVO item)
        {
            
        }

        public void BorrarItemCarrito(int cliid, int itcid)
        {

        }
        
    }
}
