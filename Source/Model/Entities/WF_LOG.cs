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
    
    public partial class WF_LOG
    {
        public long ID { get; set; }
        public Nullable<int> WF_ID { get; set; }
        public Nullable<long> NGUOIXULY_ID { get; set; }
        public string MESSAGE { get; set; }
        public Nullable<long> ITEM_ID { get; set; }
        public string ITEM_TYPE { get; set; }
        public Nullable<long> NGUONHAN_ID { get; set; }
        public Nullable<System.DateTime> create_at { get; set; }
        public Nullable<long> create_by { get; set; }
        public long NGUOI_UYQUYEN { get; set; }
        public Nullable<System.DateTime> edit_at { get; set; }
        public Nullable<long> edit_by { get; set; }
        public Nullable<int> STEP_ID { get; set; }
        public Nullable<bool> IS_RETURN { get; set; }
    }
}