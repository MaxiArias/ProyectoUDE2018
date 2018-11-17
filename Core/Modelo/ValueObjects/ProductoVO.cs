using System;

namespace Modelo.ValueObjects
{
    public class ProductoVO
    {
        // Atributos
        private int idProducto;
        private String nombre;
        private String descripcion;
        private String foto;
        private float precio;
        private int stock;
        private DateTime fechaAlta;
        private Boolean habilitado;
        private int idCategoria;

        // Properties
        public int IdProducto { get { return idProducto; } }
        public string Nombre { get { return nombre; } }
        public string Descripcion { get { return descripcion; } }
        public string Foto { get { return foto; } }
        public float Precio { get { return precio; } }
        public int Stock { get { return stock; } }
        public DateTime FechaAlta { get { return fechaAlta; } }
        public Boolean Habilitado { get { return habilitado; } }
        public int IdCategoria { get { return idCategoria; } }

        // Constructores
        public ProductoVO() { }

        public ProductoVO(int idp, string nom, string desc, string foto, float precio, int stk, DateTime alta, Boolean hab, int idCat)
        {
            idProducto = idp;
            nombre = nom;
            descripcion = desc;
            this.foto = foto;
            this.precio = precio;
            stock = stk;
            fechaAlta = alta;
            habilitado = hab;
            idCategoria = idCat;
        }
    }
}
