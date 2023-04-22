//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadMiverva
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.CompraDetalle = new HashSet<CompraDetalle>();
        }
    
        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string unidadMedida { get; set; }
        public decimal saldo { get; set; }
        public decimal precioVenta { get; set; }
        public string usuarioRegistro { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
        public Nullable<bool> registroActivo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraDetalle> CompraDetalle { get; set; }
    }
}
