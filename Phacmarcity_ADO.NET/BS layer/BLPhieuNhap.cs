using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phacmarcity_ADO.NET.ENUM;


namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLPhieuNhap
    {
        DBMain db = null;

        public BLPhieuNhap()
        {
            db = new DBMain();
        }
        public DataSet LayPhieuNhap()
        {
            return db.ExecuteQueryDataSet("select PhieuNhap.MaPN, PhieuNhap.MaNhanVien, PhieuNhap.MaNhaCungCap, PhieuNhap.NgayNhap, CTPhieuNhap.MaThuoc, CTPhieuNhap.SoLuong, CTPhieuNhap.DonGia, CTPhieuNhap.NgaySX, CTPhieuNhap.NgayHH from PhieuNhap join CTPhieuNhap on PhieuNhap.MaPN = CTPhieuNhap.MaPN", CommandType.Text);
        }
        public DataSet TimKiemPhieuNhap(string input, string key)
        {
            string query = @"WITH PhieuNhapNew AS (
                        SELECT PhieuNhap.MaPN, PhieuNhap.MaNhanVien, PhieuNhap.MaNhaCungCap, PhieuNhap.NgayNhap, CTPhieuNhap.MaThuoc, CTPhieuNhap.SoLuong, CTPhieuNhap.DonGia, CTPhieuNhap.NgaySX, CTPhieuNhap.NgayHH
                        FROM PhieuNhap
                        JOIN CTPhieuNhap ON PhieuNhap.MaPN = CTPhieuNhap.MaPN
                    )
                    SELECT *
                    FROM PhieuNhapNew
                    WHERE ";

            switch (input)
            {
                case nameof(Cls_Enum.OptionPhieuNhap.MaPN):
                case nameof(Cls_Enum.OptionPhieuNhap.MaNhanVien):
                case nameof(Cls_Enum.OptionPhieuNhap.MaNhaCungCap):
                    query += "PhieuNhapNew." + input + " LIKE '%" + key + "%'";
                    break;
                case nameof(Cls_Enum.OptionPhieuNhap.NgayNhap):
                    query += "PhieuNhapNew." + input + " = '" + key + "'";
                    break;
                case nameof(Cls_Enum.OptionCTPhieuNhap.SoLuong):
                case nameof(Cls_Enum.OptionCTPhieuNhap.MaThuoc):
                case nameof(Cls_Enum.OptionCTPhieuNhap.DonGia):
                    query += "PhieuNhapNew." + input + " LIKE '%" + key + "%'";
                    break;
                case nameof(Cls_Enum.OptionCTPhieuNhap.NgaySX):
                case nameof(Cls_Enum.OptionCTPhieuNhap.NgayHH):
                    query += "PhieuNhapNew." + input + " = '" + key + "'";
                    break;
                default:
                    break;
            }

            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        public bool ThemPhieuNhap(string MaPN, string MaNhanVien, string MaNhaCungCap, DateTime NgayNhap, ref string err)
        {
            string sqlString = "Insert Into PhieuNhap Values('" +
            MaPN + "', '" +
            MaNhanVien + "', '" + MaNhaCungCap + "', '" + NgayNhap + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool ThemCTPhieuNhap(string MaPN, string MaThuoc, int SoLuong, double DonGia, DateTime NgaySX, DateTime NgayHH, ref string err)
        {
            string sqlString = "INSERT INTO CTPhieuNhap VALUES ('" +
                   MaPN + "', '" +
                   MaThuoc + "', " +
                   SoLuong + ", " +
                   DonGia.ToString("C", CultureInfo.InvariantCulture) + ", '" +
                   NgaySX.ToString("yyyy-MM-dd") + "', '" +
                   NgayHH.ToString("yyyy-MM-dd") + "')";


            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaPhieuNhap(ref string err, string MaPhieuNhap)
        {
            string sqlString = "Delete From PhieuNhap Where MaPN='" + MaPhieuNhap + "';" + 
                "Delete From CTPhieuNhap Where MaPN='" + MaPhieuNhap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        
        public bool CapNhatPhieuNhap(string MaPhieuNhap, string MaNhanVien, string MaNhaCungCap, DateTime NgayNhap, ref string err)
        {
            string sqlString = "Update PhieuNhap Set MaNhanVien= '" + MaNhanVien + "', MaNhaCungCap= '" + MaNhaCungCap + "', NgayNhap ='" + NgayNhap + "' Where MaPN='" + MaPhieuNhap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatCTPhieuNhap(string MaPhieuNhap, string MaThuoc, int SoLuong, string DonGia, DateTime NgaySX, DateTime NgayHH, ref string err)
        {
            string sqlString = "Update PhieuNhap Set MaThuoc= '" + MaThuoc +
                    "', SoLuong= " + SoLuong +
                    ", DonGia ='" + DonGia +
                    "', NgaySX= '" + NgaySX.ToString("yyyy-MM-dd") +
                    "', NgayHH= '" + NgayHH.ToString("yyyy-MM-dd") +
                    "' Where MaPN='" + MaPhieuNhap + "'";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
