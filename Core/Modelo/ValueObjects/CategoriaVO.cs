﻿using System;

namespace Modelo.ValueObjects
{
    public class CategoriaVO
    {
        // Atributos
        private int idCategoria;
        private String nombre;
        private String descripcion;
        private Boolean habilitado;

        // Properties
        public int IdCategoria { get { return idCategoria; } }
        public string Nombre { get { return nombre; } }
        public string Descripcion { get { return descripcion; } }
        public Boolean Habilitado { get { return habilitado; } }

        // Constructores
        public CategoriaVO() { }

        public CategoriaVO(int idc, string nom, string desc, Boolean hab)
        {
            idCategoria = idc;
            nombre = nom;
            descripcion = desc;
            habilitado = hab;
        }
    }
}
