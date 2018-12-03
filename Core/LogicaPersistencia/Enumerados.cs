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
            UsuarioYaExiste = 1,
            UsuarioNoExiste = 2,
            LoginIncorrecto = 3,
            UsuarioNoHabilitado = 4,
            CategoriaYaExiste = 5,
            CategoriaNoExiste = 6,
            BackofficeNoExiste = 7,
            MonedaYaExiste = 8,
            MonedaNoExiste = 9,
            ProductoYaExiste = 10,
            ProductoNoExiste = 11,
            StockInsuficiente = 12,
            RolYaExiste = 13,
            RolNoExiste = 14,
            CedulaYaExiste = 15,
            CarritoYaExiste = 16,
            CarritoNoExiste = 17
        }
    }
}