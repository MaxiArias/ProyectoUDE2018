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
        void InsertarCategoria(CategoriaVO catvo);

        void BorrarCategoria(int catid);

        void ModificarCategoria(CategoriaVO catvo);

        void InsertarCliente(ClienteVO clivo);

        void BorrarCliente(int cliid);

        void ModificarCliente(ClienteVO clivo);

        void InsertarBackoffice(BackofficeVO bacvo);

        void BorrarBackoffice(int bacid);

        void ModificarBackoffice(BackofficeVO bacvo);

        void InsertarCarrito(CarritoVO carvo);

        void BorrarCarrito(int carid);

        void ModificarCarrito(CarritoVO carvo);

        void InsertarMoneda(MonedaVO monvo);

        void BorrarMoneda(int monid);

        void ModificarMoneda(MonedaVO monvo);

        void InsertarProducto(ProductoVO provo);

        void BorrarProducto(int proid);

        void ModificarProducto(ProductoVO provo);

        void InsertarRol(RolVO rolvo);

        void BorrarRol(int rolid);

        void ModificarRol(RolVO rolvo);

        void InsertarUsuario(UsuarioVO usuvo);

        void BorrarUsuario(int usuid);

        void ModificarUsuario(UsuarioVO usuvo);
    }
} 
