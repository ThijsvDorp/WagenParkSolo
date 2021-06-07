using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WagenParkSolo.Models
{
    public class Reservations
    {
        [Key]
        public int Autonummer { get; set; }
        public string Merk { get; set; }
        public string Kenteken { get; set; }
        public string Model { get; set; }
        public System.DateTime Van { get; set; }
        public Nullable<System.DateTime> Tot { get; set; }
    }
}