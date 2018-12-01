namespace Modelo.ValueObjects
{
    public class ItemCarritoVO
    {
        // Atributos
        //private int idProducto;
        //private int cantidad;
        //private int idCliente;
        //private int productoId;
        //private double productoPrecio;
        //private int productoCantidad;

        // Properties
        public int IdProducto { get; set; }
        public decimal ProductoPrecio { get; set;}
        public string ProductoNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public int Cantidad { get; set; }
        public int IdCliente { get; set; }

        // Constructores
        public ItemCarritoVO() { }

        public ItemCarritoVO(int idp, decimal precio, string nombre, string desc, int cantidad, int idcliente)
        {
            IdProducto = idp;
            ProductoPrecio = precio;
            ProductoNombre = nombre;
            ProductoDescripcion = desc;
            this.Cantidad = cantidad;
            this.IdCliente = idcliente;
            
        }

    }
}
