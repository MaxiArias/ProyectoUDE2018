
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
    
public partial class Cliente
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Cliente()
    {

        this.Carrito = new HashSet<Carrito>();

    }


    public int UsuarioId { get; set; }

    public string ClienteDireccion { get; set; }

    public string ClienteTelefono { get; set; }

    public Nullable<int> ClienteCI { get; set; }

    public string ClienteNombre { get; set; }

    public string EmpresaRUT { get; set; }

    public string EmpresaNombreContacto { get; set; }

    public Nullable<bool> ClienteHabilitado { get; set; }

    public string TipoCliente { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Carrito> Carrito { get; set; }

    public virtual Usuario Usuario { get; set; }

}

}
