using System;

namespace LogicaPersistencia
{
    public class Carrito
    {
        // Atributos
        private int idCarrito;

        // Properties
        public int IdCarrito { get { return idCarrito; } }
        public int IdCliente { get; set; }
        public DateTime FechaCreacion { get; set; }
      
        // Constructores
        public Carrito(int idcarro, int client, DateTime creacion)
        {
            idCarrito = idcarro;
            IdCliente = client;
            FechaCreacion = creacion;
        }


    }
}
