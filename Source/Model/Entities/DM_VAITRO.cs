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
    
    public partial class DM_VAITRO
    {
        public int DM_VAITRO_ID { get; set; }
        public string MA_VAITRO { get; set; }
        public string TEN_VAITRO { get; set; }
        public Nullable<int> TRANGTHAI { get; set; }
        public Nullable<System.DateTime> NGAYTAO { get; set; }
        public Nullable<System.DateTime> NGAYSUA { get; set; }
        public Nullable<long> NGUOITAO { get; set; }
        public Nullable<long> NGUOISUA { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<bool> IS_RECEIVE_DOC_DIRECTLY { get; set; }
    }
}