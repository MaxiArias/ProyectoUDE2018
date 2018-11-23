namespace Modelo.ValueObjects
{
    public class ItemCarritoVO
    {
        // Atributos
        private int idProducto;
        private int cantidad;
        private int idCliente;
        private int productoId;
        private double productoPrecio;
        private int productoCantidad;

        // Properties
        public int IdProducto { get { return idProducto; } }
        public decimal ProductoPrecio { get; set;}
        public string ProductoNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public int Cantidad { get { return cantidad; } }
        public int IdCliente { get { return idCliente; } }

        // Constructores
        public ItemCarritoVO() { }

        public ItemCarritoVO(int idp, decimal precio, string nombre, string desc, int cantidad, int idcliente)
        {
            idProducto = idp;
            ProductoPrecio = precio;
            ProductoNombre = nombre;
            ProductoDescripcion = desc;
            this.cantidad = cantidad;
            this.idCliente = idcliente;
            
        }

    }
}
