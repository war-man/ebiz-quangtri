using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entities;

namespace Business.CommonModel.CCTCTHANHPHAN
{
    public class CCTC_THANHPHAN_BO : CCTC_THANHPHAN
    {
        public int SoLuongCanBo { get; set; }
        public string TenLoaiDonVi { get; set; }
        public string TenCapDonVi { get; set; }
    }
}
