﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LogicaPersistencia
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class TiendaVirtualEntities : DbContext
{
    public TiendaVirtualEntities()
        : base("name=TiendaVirtualEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<BackOffice> BackOffice { get; set; }

    public virtual DbSet<Carrito> Carrito { get; set; }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<ItemCarrito> ItemCarrito { get; set; }

    public virtual DbSet<Moneda> Moneda { get; set; }

    public virtual DbSet<Producto> Producto { get; set; }

    public virtual DbSet<Rol> Rol { get; set; }

    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

}

}

