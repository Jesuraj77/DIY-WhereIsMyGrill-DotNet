using System;
using System.Collections.Generic;
using System.Text;

namespace GrillBer.Entities
{
   public class Grill
    {
        public int GrillId { get; set; }
        public string GrillType { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int UserId { get; set; }
        public int RenterId { get; set; }
        public Addons addon { get; set; }
    }
    public enum Addons
    {
        Chairs,
        Turf

    }
}

 