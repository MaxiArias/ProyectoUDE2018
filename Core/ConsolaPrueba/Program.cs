using LogicaPersistencia;
using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsolaPrueba.WSreferencia;

namespace ConsolaPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebServiceSoapClient ws = new WebServiceSoapClient();
            //CategoriaVO catvo = new CategoriaVO()
            //{
            //    Nombre = "Computadoras",
            //    Descripcion = "Computadoras y notebooks",
            //    Habilitado = true
            //};
            //ws.InsertarCategoria(catvo);

            //BackofficeInsVO bo = new BackofficeInsVO()
            //{
            //    Activo = true,
            //    Nombre = "Juan Perez",
            //    Email = "juan@prueba.com",
            //    Password = "123456",
            //    RolId = 1,
            //    TipoUsuario = "backoffice"
            //};
            //Console.WriteLine(ws.InsertarBackoffice(bo));

            IFachadaWeb ifac = new FabricaFachadas().CrearFachadaWeb;

            PersonaVO cl = new PersonaVO()
            {
                Activo = true,
                Direccion = "dir1",
                Email = "prueba3@mail3.com",
                Nombre = "nombreprueba",
                Password = "1234",
                Telefono = "099123456",
                TipoCliente = "Persona",
                TipoUsuario = "cliente",
                Cedula = 123456789
            };
            ifac.InsertarCliente(cl);

            //IFachadaWin fac = new FabricaFachadas().CrearFachadaWin;
            //fac.InsertarBackoffice(bo);
        }
    }
}
