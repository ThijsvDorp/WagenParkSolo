//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WagenParkSolo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factuurregel
    {
        public Nullable<System.DateTime> Van { get; set; }
        public Nullable<System.DateTime> Tot { get; set; }
        public int Autonummer { get; set; }
        public int Factuurnummer { get; set; }
        public int Factuurregelnummer { get; set; }
    
        public virtual Auto Auto { get; set; }
        public virtual Factuur Factuur { get; set; }
    }
}
