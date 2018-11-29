using System;

namespace Modelo.ValueObjects
{
    public class CarritoVO
    {
        // Atributos
        //private int idCarrito;
        //private int idCliente;
        //private DateTime fechaCreacion;
        //private int idMoneda;

        // Properties
        public int IdCarrito { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdMoneda { get; set; }

        // Constructores
        public CarritoVO() { }

        public CarritoVO(int idcarro, int client, DateTime creacion, int idmon)
        {
            IdCarrito = idcarro;
            IdCliente = client;
            FechaCreacion = creacion;
            IdMoneda = idmon;
        }
    }
}
