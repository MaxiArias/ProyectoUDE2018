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
            Ok,
            BackofficeNoExiste,
            CarritoNoExiste,
            CategoriaConProductosAsociados,
            CategoriaNoExiste,
            CategoriaNoHabilitada,
            CategoriaYaExiste,
            ClienteNoExiste,
            LoginIncorrecto,
            MonedaNoExiste,
            MonedaYaExiste,
            PersonaYaExiste,
            ProductoNoExiste,
            ProductoYaExiste,
            RolNoExiste,
            RolYaExiste,
            StockNegativo,
            UsuarioNoExiste,
            UsuarioNoHabilitado,
            UsuarioYaExiste,
            ErrorDesconocido
        }
    }
}