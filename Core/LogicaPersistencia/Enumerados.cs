namespace LogicaPersistencia
{
    public class Enumerados
    {
        public enum Rol
        {
            Administrador = 0,
            Operador = 1
        }

        public enum TipoUsuario
        {
            Backoffice = 0,
            Cliente = 1
        }

        public enum TipoCliente
        {
            Persona = 0,
            Empresa = 1
        }

        public enum TipoError
        {
            Ok = 0,
            MailYaExiste = 1,
            MailNoExiste = 2,
            CategoriaYaExiste = 3,
            CategoriaNoExiste = 4,
            BackofficeNoExiste = 5,
            MonedaYaExiste = 6,
            MonedaNoExiste = 7,
            ProductoYaExiste = 8,
            ProductoNoExiste = 9,
            StockInsuficiente = 10,
            RolYaExiste = 11,
            RolNoExiste = 12,
            CedulaYaExiste = 13,
            ClientYaExiste = 14,
            ClienteNoExiste = 15,
            CarritoYaExiste = 16,
            CarritoNoExiste = 17
        }
    }
}
