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

        public void ModificarNombreCategoria(int catid, string nom)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var cate = db.Categoria.Where(s => s.CategoriaId == catid).FirstOrDefault();
                cate.CategoriaNombre = nom;
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

        public List<CategoriaVO> ListarCategoriasActivas()
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {

                var producto = db.Categoria.Where(s => s.CategoriaHabilitado == true).ToList();

                return producto.Select(back => back.DarCategoriaVO()).ToList();
            }
        }

        public CategoriaVO DarCategoria(int catid)
        {

            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var cate = db.Categoria.Where(s => s.CategoriaId == catid).FirstOrDefault();
                return cate.DarCategoriaVO();
            }

        }


        public void ActivarCategoria(int catid, bool activa)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var cate = db.Categoria.Where(s => s.CategoriaId == catid).FirstOrDefault();
                cate.CategoriaHabilitado= activa;
                db.SaveChanges();
            }

        }

        public bool EstadoCategoria(int catid)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var cate = db.Categoria.Where(s => s.CategoriaId == catid).FirstOrDefault();
                return cate.CategoriaHabilitado;
            }
        }  
        
        public bool ExisteCategoria(String nombre)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var existe = (from cat in db.Categoria
                              where cat.CategoriaNombre == nombre
                              select cat).FirstOrDefault();

                return existe != null;
            }
        }

        public bool ExisteCategoria(int catid)
        {
            using (TiendaVirtualEntities db = new TiendaVirtualEntities())
            {
                var existe = (from cat in db.Categoria
                              where cat.CategoriaId == catid
                              select cat).FirstOrDefault();

                return existe != null;
            }
        }
    }
}
