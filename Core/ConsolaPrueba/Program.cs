//using LogicaPersistencia.DAO;
//using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaPrueba.TiendaVirtualWebservice;

namespace ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoriaVO catvo = new CategoriaVO(1, "Computadoras", "Computadoras y notebooks", true);
            //CategoriaDAO catdao = new CategoriaDAO();
            //catdao.InsertarCategoria(catvo);

            WebServiceSoapClient ws = new WebServiceSoapClient();
            CategoriaVO catvo = new CategoriaVO()
            {
                Nombre = "Computadoras",
                Descripcion = "Computadoras y notebooks",
                Habilitado = true
            };
            ws.InsertarCategoria(new CategoriaVO());
        }
    }
}
