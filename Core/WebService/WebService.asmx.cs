using LogicaPersistencia;
using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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
        public bool UsuarioLogin(String mail,String password)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.UsuarioLogin(mail, password);
        }

        //metodos de categoria
        [WebMethod]
        public void InsertarCategoria(CategoriaVO catvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarCategoria(catvo);
        }

        [WebMethod]
        public void BorrarCategoria(int catid)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarCategoria(catid);
        }

        [WebMethod]
        public void ModificarDescripcionCategoria(int cateid, string desc)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarDescripcionCategoria(cateid,desc);
        }

        [WebMethod]
        public List<CategoriaVO> ListarCategorias()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarCategorias();
        }

        [WebMethod]
        public CategoriaVO DarCategoria(int catid)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.DarCategoria(catid);
        }

        //metodos backoffice
        [WebMethod]
        public void InsertarBackoffice(BackofficeInsVO bacvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarBackoffice(bacvo);
        }

        [WebMethod]
        public void BorrarBackoffice(int bacid)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarBackoffice(bacid);
        }

        [WebMethod]
        public void CambiarRolBackoffice(int bacid, int rolid)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.CambiarRolBackoffice(bacid, rolid);
        }

        [WebMethod]
        public List<BackofficeVO> ListarBackoffice()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarBackoffice();
        }

        //metodos de moneda
        [WebMethod]
        public void InsertarMoneda(MonedaVO monvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarMoneda(monvo);
        }

        [WebMethod]
        public void BorrarMoneda(int monid)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarMoneda(monid);
        }

        [WebMethod]
        public void ModificarMonedaCotizacion(int monedaid , decimal cotiza)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarMonedaCotizacion(monedaid, cotiza);
        }

        [WebMethod]
        public List<MonedaVO> ListarMonedas()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarMonedas();
        }

        //metodos de producto
        [WebMethod]
        public void InsertarProducto(ProductoVO provo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarProducto(provo);
        }

        [WebMethod]
        public void BorrarProducto(int proid)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarProducto(proid);
        }

        [WebMethod]
        public void ModificarProducto(ProductoVO provo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarProducto(provo);
        }

        [WebMethod]
        public void ModificarStockProducto(int proid, int stock)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarStockProducto(proid, stock);
        }

        [WebMethod]
        public void HabilitarProducto(int proid, Boolean habilito)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.HabilitarProducto(proid, habilito);
        }

        [WebMethod]
        public List<ProductoVO> ListarProductos()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarProductos();
        }

        //metodos de rol
        [WebMethod]
        public void InsertarRol(RolVO rolvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarRol(rolvo);
        }

        [WebMethod]
        public void BorrarRol(int rolid)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarRol(rolid);
        }

        [WebMethod]
        public void ModificarRol(int rolid, string nomb)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarRol(rolid, nomb);
        }

        [WebMethod]
        public List<RolVO> ListarRoles()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarRoles();
        }

        //metodos de cliente
        [WebMethod]
        public void BorrarCliente(int cliid)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarCliente(cliid);
        }

        [WebMethod]
        public List<ClienteVO> ListarClientes()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarClientes();
        }
    }
}
