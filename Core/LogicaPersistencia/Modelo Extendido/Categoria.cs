using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaPersistencia
{
    public partial class Categoria
    {

        public Categoria(CategoriaVO vo)
        {
            this.CategoriaNombre = vo.Nombre;
            this.CategoriaDescripcion = vo.Descripcion;
            this.CategoriaHabilitado = vo.Habilitado;
        }

        public CategoriaVO DarCategoria()
        {

            return new CategoriaVO(CategoriaId, CategoriaNombre, CategoriaDescripcion, CategoriaHabilitado);

        }


    }


}
}
