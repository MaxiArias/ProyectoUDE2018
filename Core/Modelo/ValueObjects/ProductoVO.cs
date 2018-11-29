using System;

namespace Modelo.ValueObjects
{
    public class ProductoVO
    {
        // Atributos
        //private int idProducto;
        
            // Properties
        public int IdProducto { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set;}
        public string Foto { get; set;}
        public decimal Precio { get; set;}
        public int Stock { get; set;}
        public DateTime FechaAlta { get; set;}
        public Boolean Habilitado { get; set;}
        public int IdCategoria { get; set;}

        // Constructores
        public ProductoVO() { }

        public ProductoVO(int idp, string nom, string desc, string foto, decimal precio, int stk, DateTime alta, Boolean hab, int idCat)
        {
            IdProducto = idp;
            Nombre = nom;
            Descripcion = desc;
            Foto = foto;
            Precio = precio;
            Stock = stk;
            FechaAlta = alta;
            Habilitado = hab;
            IdCategoria = idCat;
        }
    }
}
