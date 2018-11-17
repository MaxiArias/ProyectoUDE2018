namespace Modelo.ValueObjects
{
    public class ItemCarritoVO
    {
        // Atributos
        private int idProducto;
        private int cantidad;
        private int idCliente;
        
        // Properties
        public int IdProducto { get { return idProducto; } }
        public int Cantidad { get { return cantidad; } }
        public int IdCliente { get { return idCliente; } }

        // Constructores
        public ItemCarritoVO() { }

        public ItemCarritoVO(int idp, int cant, int idcliente)
        {
            idProducto = idp;
            cantidad = cant;
            idCliente = idcliente;
        }
    }
}
