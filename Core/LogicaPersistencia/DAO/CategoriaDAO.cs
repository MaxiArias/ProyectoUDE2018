using Modelo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LogicaPersistencia.DAO
{
    public class CategoriaDAO
    {
        public void InsertarCategoria(CategoriaVO catvo)
        {
            Categoria cat = new Categoria(catvo);

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Categoria.Add(cat);
                db.SaveChanges();
            }

        }

        public void BorrarCategoria(CategoriaVO catvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(catvo).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void ModificarCategoria(CategoriaVO catvo)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                db.Entry(catvo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<CategoriaVO> ListarCategorias()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                return db.Categoria.ToList().Select(back => back.DarCategoriaVO()).ToList();
            }
        }

    }
}
