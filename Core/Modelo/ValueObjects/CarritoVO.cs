using System;

namespace Modelo.ValueObjects
{
    public class CarritoVO
    {
        // Atributos
        private int idCarrito;
        private int idCliente;
        private DateTime fechaCreacion;
        private int idMoneda;

        // Properties
        public int IdCarrito { get { return idCarrito; } }
        public int IdCliente { get { return idCliente; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } }
        public int IdMoneda { get { return idMoneda; } }

        // Constructores
        public CarritoVO(int idcarro, int client, DateTime creacion, int idmon)
        {
            idCarrito = idcarro;
            idCliente = client;
            fechaCreacion = creacion;
            idMoneda = idmon;
        }
    }
}
