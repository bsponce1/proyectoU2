//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoDesarrWebU2.Models.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.factura = new HashSet<factura>();
        }
    
        public int idusuario { get; set; }
        public string nombreusuario { get; set; }
        public string apellidousuario { get; set; }
        public string generousuario { get; set; }
        public string cedulausuario { get; set; }
        public string telefonousuario { get; set; }
        public string direccionusuario { get; set; }
        public string correousuario { get; set; }
        public string claveusuario { get; set; }
        public string imagenusuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<factura> factura { get; set; }
    }
}
