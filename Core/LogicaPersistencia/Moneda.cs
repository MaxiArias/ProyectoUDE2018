namespace LogicaPersistencia
{
    public class Moneda
    {
        // Atributos
        private int idMoneda;

        // Properties
        public int IdMoneda { get { return idMoneda; } }
        public string Abreviatura { get; set; }
        public string Descripcion { get; set; }
        public float Cotizacion { get; set; }

        // Constructores
        public Moneda(int idm, string abrev, string desc, float cotiza)
        {
            idMoneda = idm;
            Abreviatura = abrev;
            Descripcion = desc;
            Cotizacion = cotiza;
        }
        
    }

}
