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
        [WebMethod]
        public bool UsuarioLogin(String mail,String password)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.UsuarioLogin(mail, password);
        }

        [WebMethod]
        public void InsertarCategoria(CategoriaVO catvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarCategoria(catvo);
        }

        [WebMethod]
        public void BorrarCategoria(CategoriaVO catvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarCategoria(catvo);
        }

        [WebMethod]
        public void ModificarCategoria(CategoriaVO catvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarCategoria(catvo);
        }

        [WebMethod]
        public List<CategoriaVO> ListarCategorias()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarCategorias();
        }

        [WebMethod]
        public void InsertarBackoffice(BackofficeInsVO bacvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarBackoffice(bacvo);
        }

        [WebMethod]
        public void BorrarBackoffice(BackofficeVO bacvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarBackoffice(bacvo);
        }

        [WebMethod]
        public void ModificarBackoffice(BackofficeVO bacvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarBackoffice(bacvo);
        }

        [WebMethod]
        public List<BackofficeVO> ListarBackoffice()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarBackoffice();
        }

        [WebMethod]
        public void InsertarMoneda(MonedaVO monvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarMoneda(monvo);
        }

        [WebMethod]
        public void BorrarMoneda(MonedaVO monvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarMoneda(monvo);
        }

        [WebMethod]
        public void ModificarMoneda(MonedaVO monvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarMoneda(monvo);
        }

        [WebMethod]
        public List<MonedaVO> ListarMonedas()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarMonedas();
        }

        [WebMethod]
        public void InsertarProducto(ProductoVO provo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarProducto(provo);
        }

        [WebMethod]
        public void BorrarProducto(ProductoVO provo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarProducto(provo);
        }

        [WebMethod]
        public void ModificarProducto(ProductoVO provo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarProducto(provo);
        }

        [WebMethod]
        public List<ProductoVO> ListarProductos()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarProductos();
        }

        [WebMethod]
        public void InsertarRol(RolVO rolvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.InsertarRol(rolvo);
        }

        [WebMethod]
        public void BorrarRol(RolVO rolvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.BorrarRol(rolvo);
        }

        [WebMethod]
        public void ModificarRol(RolVO rolvo)
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            fac.ModificarRol(rolvo);
        }

        [WebMethod]
        public List<RolVO> ListarRoles()
        {
            IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            return fac.ListarRoles();
        }
    }
}
