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
    
    public partial class UtilizzoVeicoli
    {
        public int IdUtilizzoVeicoli { get; set; }
        public int IdVeicolo { get; set; }
        public System.DateTime DataInizio { get; set; }
        public System.DateTime DataFine { get; set; }
        public Nullable<int> KmInizio { get; set; }
        public Nullable<int> KmFine { get; set; }
        public string Destinazione { get; set; }
        public Nullable<decimal> CostoCarburante { get; set; }
        public Nullable<decimal> CostoPedaggio { get; set; }
        public System.Guid IdAnagrafica { get; set; }
        public string IdCommessa { get; set; }
    
        public virtual Veicoli Veicoli { get; set; }
    }
}
