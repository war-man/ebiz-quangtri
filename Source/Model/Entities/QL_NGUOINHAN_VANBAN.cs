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
    
    public partial class QL_NGUOINHAN_VANBAN
    {
        public int ID { get; set; }
        public string TEN_NHOM { get; set; }
        public string NGUOINHAN_IDS { get; set; }
        public Nullable<int> DM_PHONGBAN_ID { get; set; }
        public Nullable<bool> IS_DELETE { get; set; }
        public Nullable<bool> IS_DEFAULT { get; set; }
    }
}
