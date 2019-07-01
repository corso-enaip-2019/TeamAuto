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
    
    public partial class Veicoli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Veicoli()
        {
            this.ManutenzioniVeicolis = new HashSet<ManutenzioniVeicoli>();
            this.ScadenzeVeicolis = new HashSet<ScadenzeVeicoli>();
            this.StatoVeicolis = new HashSet<StatoVeicoli>();
            this.UtilizzoVeicolis = new HashSet<UtilizzoVeicoli>();
        }
    
        public int IdVeicolo { get; set; }
        public string Targa { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Versione { get; set; }
        public string Telaio { get; set; }
        public Nullable<System.DateTime> Immatricolazione { get; set; }
        public Nullable<int> Cilindrata { get; set; }
        public Nullable<int> CvVapore { get; set; }
        public Nullable<int> Kw { get; set; }
        public Nullable<int> CvFiscali { get; set; }
        public string Colore { get; set; }
        public string Formato { get; set; }
        public string Alimentazione { get; set; }
        public string NormativaEuro { get; set; }
        public string Provincia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManutenzioniVeicoli> ManutenzioniVeicolis { get; set; }
        public virtual Province Province { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScadenzeVeicoli> ScadenzeVeicolis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatoVeicoli> StatoVeicolis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UtilizzoVeicoli> UtilizzoVeicolis { get; set; }
    }
}