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
    
    public partial class Carrito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carrito()
        {
            this.ItemCarrito = new HashSet<ItemCarrito>();
        }
    
        public int CarritoId { get; set; }
        public int UsuarioId { get; set; }
        public int MonedaId { get; set; }
        public System.DateTime CarritoFechaCreacion { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Moneda Moneda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCarrito> ItemCarrito { get; set; }
    }
}
