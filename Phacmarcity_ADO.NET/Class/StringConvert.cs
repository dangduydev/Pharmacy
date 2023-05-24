using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Phacmarcity_ADO.NET.Class
{
    public static class StringConvert
    {
        public static string ConvertToEnumPhieuNhap(string input)
        {
            switch (input)
            {
                case "Ngày sản xuất":
                    return "NgaySX";
                case "Hạn sử dụng":
                    return "NgayHH";
                case "Ngày nhập":
                    return "NgayNhap";
                case "Mã phiếu nhập":
                    return "MaPN";
                case "Mã nhân viên":
                    return "MaNhanVien";
                case "Mã thuốc":
                    return "MaThuoc";
                case "Nhà cung cấp":
                    return "MaNhaCungCap";
                case "Số lượng":
                    return "SoLuong";
                case "Đơn giá":
                    return "DonGia";
                default:
                    return "";
            }
        }
        public static string ConvertToEnumPhieuXuat(string input)
        {
            switch (input)
            {
                case "Ngày xuất":
                    return "NgayXuat";
                default:
                    return "";
            }
        }
        public static string ConvertToEnumEmployee(string input)
        {
            switch (input)
            {
                case "Ngày sinh":
                    return "NgaySinh";
                case "Ngày vào làm":
                    return "NgayVaoLam";
                case "Mã nhân viên":
                    return "MaNhanVien";
                case "Tên nhân viên":
                    return "HoTen";
                case "Số điện thoại":
                    return "SoDienThoai";
                case "Bộ phận":
                    return "BoPhan";

                default:
                    return "";
            }
        }
        public static string ConvertToEnumClient(string input)
        {
            switch (input)
            {
                case "Mã khách hàng":
                    return "MaKhachHang";
                case "Tên khách hàng":
                    return "TenKhachHang";
                case "Số điện thoại":
                    return "SoDienThoai";
                case "Địa chỉ":
                    return "DiaChi";
                default:
                    return "";
            }
        }

    }
}
