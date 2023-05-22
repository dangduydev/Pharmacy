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
            NgaySX,
            NgayHH,
            NgayNhap,
            MaPN,
            MaNhanVien,
            MaNhaCungCap
        }
        public enum OptionCTPhieuNhap
        {
            MaThuoc,
            SoLuong,
            DonGia,
            NgaySX,
            NgayHH
        }
        public enum OptionPhieuXuat
        {
            NgayXuat
        }
        public enum OptionEmployee
        {
            MaNhanVien,
            HoTen,
            BoPhan,
            SoDienThoai,
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
