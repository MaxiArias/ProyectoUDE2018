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

        public void BorrarCategoria(int catid)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
                {
                    var cate = db.Categoria.Where(s => s.CategoriaId == catid).FirstOrDefault();
                    db.Categoria.Remove(cate);
                    db.SaveChanges();
                }
         }
        

        public void ModificarDescripcionCategoria(int catid , string desc)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var cate = db.Categoria.Where(s => s.CategoriaId == catid).FirstOrDefault();
                cate.CategoriaDescripcion = desc;
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
