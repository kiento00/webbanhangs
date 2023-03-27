using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webbanhangs.Context;
namespace webbanhangs.Models
{
    public class HomeModel
    {
        public List<LoaiSanPham> ListLoaiSanPham { get; set; }
        public List<SanPham> ListSanPham { get; set; }
    }
}