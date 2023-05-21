using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.ENUM
{
    public static class Cls_Enum
    {
        public enum OptionPhieuNhap
        {
            NgaySanXuat,
            HanSuDung,
            NgayNhap
        }
        public enum OptionPhieuXuat
        {
            NgayXuat
        }
        public enum OptionEmployee
        {
            NgaySinh,
            NgayVaoLam
        }
        public enum OptionClient
        {
            MaKhachHang,
            TenKhachHang,
            SoDienThoai,
            DiaChi
        }
    }
}
