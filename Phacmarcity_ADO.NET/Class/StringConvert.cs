using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.Class
{
    public static class StringConvert
    {
        public static string ConvertToEnumPhieuNhap(string input)
        {
            switch (input)
            {
                case "Ngày sản xuất":
                    return "NgaySanXuat";
                case "Hạn sử dụng":
                    return "HanSuDung";
                case "Ngày nhập":
                    return "NgayNhap";
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
