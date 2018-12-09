using LogicaPersistencia;
using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using LogicaPersistencia.Excepciones;

namespace WebService
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://TiendaVirtual.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        //metodos de usuario
        [WebMethod]
        public Enumerados.TipoError UsuarioLoginWIN(String mail, String password)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.UsuarioLoginWIN(mail, password);
                return Enumerados.TipoError.Ok;
            }
            catch (UsuarioNoExisteException)
            {
                return Enumerados.TipoError.UsuarioNoExiste;
            }
            catch (LoginIncorrectoException)
            {
                return Enumerados.TipoError.LoginIncorrecto;
            }
            catch (UsuarioNoHabilitadoException)
            {
                return Enumerados.TipoError.UsuarioNoHabilitado;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ActivaUsuario(int usrid, bool activo)
        { 
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.ActivaUsuario(usrid, activo);
                return Enumerados.TipoError.Ok;
            }
            catch (UsuarioNoExisteException)
            {
                return Enumerados.TipoError.UsuarioNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        //metodos de categoria
        [WebMethod]
        public Enumerados.TipoError InsertarCategoria(CategoriaVO catvo)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.InsertarCategoria(catvo);
                return Enumerados.TipoError.Ok;
            }
            catch (CategoriaYaExisteException)
            {
                return Enumerados.TipoError.CategoriaYaExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError BorrarCategoria(int catid)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.BorrarCategoria(catid);
                return Enumerados.TipoError.Ok;
            }
            catch (CategoriaNoExisteException)
            {
                return Enumerados.TipoError.CategoriaNoExiste;
            }
            catch (CategoriaConProductosAsociadosException)
            {
                return Enumerados.TipoError.CategoriaConProductosAsociados;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ModificarDescripcionCategoria(int cateid, string desc)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.ModificarDescripcionCategoria(cateid, desc);
                return Enumerados.TipoError.Ok;
            }
            catch (CategoriaNoExisteException)
            {
                return Enumerados.TipoError.CategoriaNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ListarCategorias(out List<CategoriaVO> lista)
        {
            lista = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                lista = fac.ListarCategorias();
                return Enumerados.TipoError.Ok;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError DarCategoria(int catid, out CategoriaVO catvo)
        {
            catvo = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                catvo = fac.DarCategoria(catid);
                return Enumerados.TipoError.Ok;
            }
            catch (CategoriaNoExisteException)
            {
                return Enumerados.TipoError.CategoriaNoExiste;
            }
        }

        [WebMethod]
        public Enumerados.TipoError EstadoCategoria(int catid, out bool activo)
        {
            activo = false;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                activo = fac.EstadoCategoria(catid);
                return Enumerados.TipoError.Ok;
            }
            catch(CategoriaNoExisteException)
            {
                return Enumerados.TipoError.CategoriaNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ActivarCategoria(int catid, bool activa)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.ActivarCategoria(catid, activa);
                return Enumerados.TipoError.Ok;
            }
            catch (CategoriaNoExisteException)
            {
                return Enumerados.TipoError.CategoriaNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ModificarNombreCategoria(int catid, string nom)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.ModificarNombreCategoria(catid, nom);
                return Enumerados.TipoError.Ok;
    }
            catch (CategoriaNoExisteException)
            {
                return Enumerados.TipoError.CategoriaNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        //metodos backoffice
        [WebMethod]
        public Enumerados.TipoError InsertarBackoffice(BackofficeInsVO bacvo)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.InsertarBackoffice(bacvo);
                return Enumerados.TipoError.Ok;
            }
            catch (UsuarioYaExisteException)
            {
                return Enumerados.TipoError.UsuarioYaExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError BorrarBackoffice(int bacid)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.BorrarBackoffice(bacid);
                return Enumerados.TipoError.Ok;
            }
            catch (BackofficeNoExisteException)
            {
                return Enumerados.TipoError.BackofficeNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError CambiarRolBackoffice(int bacid, int rolid)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.CambiarRolBackoffice(bacid, rolid);
                return Enumerados.TipoError.Ok;
            }
            catch (BackofficeNoExisteException)
            {
                return Enumerados.TipoError.BackofficeNoExiste;
            }
            catch (RolNoExisteException)
            {
                return Enumerados.TipoError.RolNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ListarBackoffice(out List<BackofficeVO> lista)
        {
            lista = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                lista = fac.ListarBackoffice();
                return Enumerados.TipoError.Ok;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        //metodos de moneda
        [WebMethod]
        public Enumerados.TipoError InsertarMoneda(MonedaVO monvo)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.InsertarMoneda(monvo);
                return Enumerados.TipoError.Ok;
            }
            catch (MonedaYaExisteException)
            {
                return Enumerados.TipoError.MonedaYaExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError BorrarMoneda(int monid)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.BorrarMoneda(monid);
                return Enumerados.TipoError.Ok;
            }
            catch (MonedaNoExisteException)
            {
                return Enumerados.TipoError.MonedaNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ModificarMonedaCotizacion(int monedaid , decimal cotiza)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.ModificarMonedaCotizacion(monedaid, cotiza);
                return Enumerados.TipoError.Ok;
            }
            catch (MonedaNoExisteException)
            {
                return Enumerados.TipoError.MonedaNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ListarMonedas(out List<MonedaVO> lista)
        {
            lista = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                lista = fac.ListarMonedas();
                return Enumerados.TipoError.Ok;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        //metodos de producto
        [WebMethod]
        public Enumerados.TipoError InsertarProducto(ProductoVO provo)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.InsertarProducto(provo);
                return Enumerados.TipoError.Ok;
            }
            catch (ProductoYaExisteException)
            {
                return Enumerados.TipoError.ProductoYaExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError BorrarProducto(int proid)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.BorrarProducto(proid);
                return Enumerados.TipoError.Ok;
            }
            catch (ProductoNoExisteException)
            {
                return Enumerados.TipoError.ProductoNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ModificarProducto(ProductoVO provo)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.ModificarProducto(provo);
                return Enumerados.TipoError.Ok;
            }
            catch (ProductoNoExisteException)
            {
                return Enumerados.TipoError.ProductoNoExiste;
            }
            catch (ProductoYaExisteException)
            {
                return Enumerados.TipoError.ProductoYaExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ModificarStockProducto(int proid, int stock)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.ModificarStockProducto(proid, stock);
                return Enumerados.TipoError.Ok;
            }
            catch (ProductoNoExisteException)
            {
                return Enumerados.TipoError.ProductoNoExiste;
            }
            catch (StockNegativoException)
            {
                return Enumerados.TipoError.StockNegativo;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError HabilitarProducto(int proid, Boolean habilito)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.HabilitarProducto(proid, habilito);
                return Enumerados.TipoError.Ok;
            }
            catch (ProductoNoExisteException)
            {
                return Enumerados.TipoError.ProductoNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ListarProductos(out List<ProductoVO> lista)
        {
            lista = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                lista = fac.ListarProductos();
                return Enumerados.TipoError.Ok;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        public Enumerados.TipoError DarProductoPorId(int proid, out ProductoVO provo)
        {
            provo = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                provo = fac.DarProductoPorId(proid);
                return Enumerados.TipoError.Ok;
            }
            catch (ProductoNoExisteException)
            {
                return Enumerados.TipoError.ProductoNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        public Enumerados.TipoError ListarProductosPorCategoria(int catid, out List<ProductoVO> lista)
        {
            lista = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                lista = fac.ListarProductosPorCategoria(catid);
                return Enumerados.TipoError.Ok;
            }
            catch (CategoriaNoExisteException)
            {
                return Enumerados.TipoError.CarritoNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        //metodos de rol
        [WebMethod]
        public Enumerados.TipoError InsertarRol(RolVO rolvo)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.InsertarRol(rolvo);
                return Enumerados.TipoError.Ok;
            }
            catch (RolYaExisteException)
            {
                return Enumerados.TipoError.RolYaExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError BorrarRol(int rolid)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.BorrarRol(rolid);
                return Enumerados.TipoError.Ok;
            }
            catch (RolNoExisteException)
            {
                return Enumerados.TipoError.RolNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ModificarRol(int rolid, string nomb)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.ModificarRol(rolid, nomb);
                return Enumerados.TipoError.Ok;
            }
            catch (RolNoExisteException)
            {
                return Enumerados.TipoError.RolNoExiste;
            }
            catch (RolYaExisteException)
            {
                return Enumerados.TipoError.RolYaExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ListarRoles(out List<RolVO> lista)
        {
            lista = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                lista = fac.ListarRoles();
                return Enumerados.TipoError.Ok;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        //metodos de cliente
        [WebMethod]
        public Enumerados.TipoError BorrarCliente(int cliid)
        {
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                fac.BorrarCliente(cliid);
                return Enumerados.TipoError.Ok;
            }
            catch (ClienteNoExisteException)
            {
                return Enumerados.TipoError.ClienteNoExiste;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }

        [WebMethod]
        public Enumerados.TipoError ListarClientes(out List<ClienteVO> lista)
        {
            lista = null;
            List<PersonaVO> listaP = null;
            List<EmpresaVO> listaE = null;
            try
            {
                IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
                listaP = fac.ListarPersonas();
                listaE = fac.ListarEmpresas();
                lista.AddRange(listaP);
                lista.AddRange(listaE);
                return Enumerados.TipoError.Ok;
            }
            catch (Exception)
            {
                return Enumerados.TipoError.ErrorDesconocido;
            }
        }
    }
}
