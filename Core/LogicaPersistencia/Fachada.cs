using LogicaPersistencia.DAO;
using Modelo.ValueObjects;

namespace LogicaPersistencia
{
    public class Fachada /*: IfachadaWin, IfachadaWeb*/
    {
        public void AltaCategoria (CategoriaVO catvo)
        {
            CategoriaDAO catdao = new CategoriaDAO();
            catdao.InsertarCategoria(catvo);
        }

    }
}
