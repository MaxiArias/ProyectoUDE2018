using System;

namespace LogicaPersistencia
{
    public class Producto
    {
        // Atributos
        private int idProducto;

        // Properties
        public int IdProducto { get { return idProducto; } }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaAlta { get; set; }
        public Boolean Habilitado { get; set; }

        // Constructores
        public Producto(int idp,int idc, string nom, string desc,string foto, float precio, int stk, DateTime alta, Boolean hab)
        {
            idProducto = idp;
            IdCategoria = idc;
            Nombre = nom;
            Descripcion = desc;
            Foto = foto;
            Precio = precio;
            Stock = stk;
            FechaAlta = alta;
            Habilitado = hab;
        }

    }
}
