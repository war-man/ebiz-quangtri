//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHIASE_TAILIEU
    {
        public int ID { get; set; }
        public Nullable<long> USER_YEU_CAU { get; set; }
        public Nullable<long> USER_CHIA_SE { get; set; }
        public Nullable<long> USER_PHE_DUYET { get; set; }
        public string TIEUDE { get; set; }
        public string NOIDUNG_YEUCAU { get; set; }
        public string NOIDUNG_PHEDUYET { get; set; }
        public string NOIDUNG_CHIASE { get; set; }
        public Nullable<System.DateTime> DATE_YEU_CAU { get; set; }
        public Nullable<System.DateTime> DATE_PHE_DUYET { get; set; }
        public Nullable<System.DateTime> DATE_CHIA_SE { get; set; }
        public Nullable<int> STATUS { get; set; }
    }
}