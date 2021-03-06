using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model.Entities;
using Business.CommonModel.CCTCTHANHPHAN;
using System.Web.Mvc;

namespace Web.Areas.CCTCTHANHPHANArea.Models
{
    public class EditVM
    {
        public CCTC_THANHPHAN objModel { get; set; }
        public CCTC_THANHPHAN_BO objBOModel { get; set; }
        public List<SelectListItem> GroupDepts { get; set; }
        public List<SelectListItem> GroupTypes { get; set; }
        public List<SelectListItem> GroupLevels { get; set; }
    }
}
