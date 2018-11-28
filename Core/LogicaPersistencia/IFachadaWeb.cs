using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public interface IFachadaWeb
    {
        bool UsuarioLogin(string mail, string password);

        List<CategoriaVO> ListarCategorias();

        List<ProductoVO> ListarProductos();
    }
}
