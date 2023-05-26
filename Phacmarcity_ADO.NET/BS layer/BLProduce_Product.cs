using Phacmarcity_ADO.NET.DB_layer;
using Phacmarcity_ADO.NET.ENUM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLProduce_Product
    {
        DBMain db = null;
        public BLProduce_Product()
        {
            db = new DBMain();
        }
        public DataSet LayPhieuXuat()
        {
            return db.ExecuteQueryDataSet("SELECT * FROM PhieuXuat JOIN CTPhieuXuat ON PhieuXuat.MaPX = CTPhieuXuat.MaPX", CommandType.Text);
        }
        public bool ThemPhieuXuat(string MaPX,
            string MaNhanVien,
            string MaKhachHang,
            string MaThuoc,
            string SoLuong,
            string DonGia, DateTime NgayXuat,
            ref string err)
        {
            string sqlString = "select PhieuXuat.MaPN, PhieuXuat.MaNhanVien, PhieuXuat.MaKhachHang, PhieuXuat.NgayXuat, CTPhieuXuat.MaThuoc, CTPhieuXuat.SoLuong, CTPhieuXuat.DonGia from PhieuXuat join CTPhieuXuat on PhieuXuat.MaPX = CTPhieuXuat.MaPX";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemPhieuXuat(string input, string tuKhoa)
        {
            string query = @"WITH PhieuXuatNew AS (
                        SELECT PhieuXuat.MaPx, PhieuXuat.MaNhanVien, PhieuXuat.MaKhachHang, PhieuXuat.NgayXuat, CTPhieuXuat.MaThuoc, CTPhieuXuat.SoLuong, CTPhieuXuat.DonGia
                        FROM PhieuXuat
                        JOIN CTPhieuXuat ON PhieuXuat.MaPX = CTPhieuXuat.MaPX
                    )
                    SELECT *
                    FROM PhieuXuatNew
                    WHERE ";

            switch (input)
            {
                case nameof(Cls_Enum.OptionPhieuXuat.MaPX):
                case nameof(Cls_Enum.OptionPhieuXuat.MaNhanVien):
                case nameof(Cls_Enum.OptionPhieuXuat.MaKhachHang):
                    query += "PhieuXuatNew." + input + " LIKE '%" + tuKhoa + "%'";
                    break;
                case nameof(Cls_Enum.OptionPhieuXuat.NgayXuat):
                    query += "PhieuXuatNew." + input + " = '" + tuKhoa + "'";
                    break;
                case nameof(Cls_Enum.OptionPhieuXuat.SoLuong):
                case nameof(Cls_Enum.OptionPhieuXuat.MaThuoc):
                case nameof(Cls_Enum.OptionPhieuXuat.DonGia):
                    query += "PhieuXuatNew." + input + " LIKE '%" + tuKhoa + "%'";
                    break;

                default:
                    break;
            }
            return db.ExecuteQueryDataSet(query, CommandType.Text);

        }

        public bool XoaPhieuXuat(ref string err, string MaPX)
        {
            string sqlString = "DELETE FROM CTPhieuXuat WHERE MaPX = '" + MaPX + "';" +
                               "DELETE FROM PhieuXuat WHERE MaPX = '" + MaPX + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatPhieuXuat(string MaPX, string MaNhanVien, string MaKhachHang, string MaThuoc, string SoLuong, string DonGia, DateTime NgayXuat, ref string err)
        {
            string sqlString = "UPDATE PhieuXuat SET MaNhanVien = N'" + MaNhanVien + "', MaKhachHang = '" + MaKhachHang + "', NgayXuat = '" + NgayXuat.ToString("yyyy-MM-dd") + "' WHERE MaPX = '" + MaPX + "';" +
                               "UPDATE CTPhieuXuat SET MaThuoc = N'" + MaThuoc + "', SoLuong = " + SoLuong + ", DonGia = " + DonGia + " WHERE MaPX = '" + MaPX + "';";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


    }
}
