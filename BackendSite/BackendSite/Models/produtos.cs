//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackendSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class produtos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produtos()
        {
            this.pedidos = new HashSet<pedidos>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int id_categoria { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pedidos> pedidos { get; set; }
        public virtual categoria categoria { get; set; }
    }
}
