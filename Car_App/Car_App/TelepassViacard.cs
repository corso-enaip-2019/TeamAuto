//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_App
{
    using System;
    using System.Collections.Generic;
    
    public partial class TelepassViacard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TelepassViacard()
        {
            this.StatoVeicolis = new HashSet<StatoVeicoli>();
            this.StatoVeicolis1 = new HashSet<StatoVeicoli>();
        }
    
        public int IdTelepassViacard { get; set; }
        public string TelepassViacard1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatoVeicoli> StatoVeicolis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatoVeicoli> StatoVeicolis1 { get; set; }
    }
}