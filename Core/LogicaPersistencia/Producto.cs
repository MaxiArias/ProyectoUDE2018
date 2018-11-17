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
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.ItemCarrito = new HashSet<ItemCarrito>();
        }
    
        public int ProductoId { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public string ProductoFoto { get; set; }
        public double ProductoPrecio { get; set; }
        public int ProductoStock { get; set; }
        public System.DateTime ProductoFechaAlta { get; set; }
        public bool ProductoHabilitado { get; set; }
        public int CategoriaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCarrito> ItemCarrito { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
