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
    
    public partial class DM_NGUOIDUNG
    {
        public long ID { get; set; }
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public string MAHOA_MK { get; set; }
        public Nullable<int> TRANGTHAI { get; set; }
        public Nullable<System.DateTime> NGAYTAO { get; set; }
        public Nullable<System.DateTime> NGAYSUA { get; set; }
        public string NGUOITAO { get; set; }
        public string DIENTHOAI { get; set; }
        public Nullable<int> DM_PHONGBAN_ID { get; set; }
        public string NGUOISUA { get; set; }
        public string HOTEN { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public string ANH_DAIDIEN { get; set; }
        public Nullable<int> CHUCVU_ID { get; set; }
        public string EMAILPASS { get; set; }
        public string CODERESETPASS { get; set; }
        public string TOKEN { get; set; }
        public Nullable<bool> IS_ACTIVE { get; set; }
        public string signpath { get; set; }
    }
}