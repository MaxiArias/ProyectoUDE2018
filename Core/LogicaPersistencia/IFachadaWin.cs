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
        bool UsuarioLogin(string mail, string password);

        void InsertarCategoria(CategoriaVO catvo);

        void BorrarCategoria(CategoriaVO catvo);

        void ModificarCategoria(CategoriaVO catvo);

        List<CategoriaVO> ListarCategorias();

        void InsertarBackoffice(BackofficeInsVO bacvo);

        void BorrarBackoffice(BackofficeVO bacvo);

        void ModificarBackoffice(BackofficeVO bacvo);

        List<BackofficeVO> ListarBackoffice();

        void InsertarMoneda(MonedaVO monvo);

        void BorrarMoneda(MonedaVO monvo);

        void ModificarMoneda(MonedaVO monvo);

        List<MonedaVO> ListarMonedas();

        void InsertarProducto(ProductoVO provo);

        void BorrarProducto(ProductoVO provo);

        void ModificarProducto(ProductoVO provo);

        List<ProductoVO> ListarProductos();

        void InsertarRol(RolVO rolvo);

        void BorrarRol(RolVO rolvo);

        void ModificarRol(RolVO rolvo);

        List<RolVO> ListarRoles();

        //void InsertarUsuario(UsuarioVO usuvo);

        //void BorrarUsuario(int usuid);

        //void ModificarUsuario(UsuarioVO usuvo);
    }
} 
