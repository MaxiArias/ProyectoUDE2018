using LogicaPersistencia.DAO;
using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriaVO catvo = new CategoriaVO(1, "Computadoras", "Computadoras y notebooks", true);
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.InsertarCategoria(catvo);
        }
    }
}
