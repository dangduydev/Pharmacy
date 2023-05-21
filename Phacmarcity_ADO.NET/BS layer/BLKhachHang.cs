using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using Phacmarcity_ADO.NET.DB_layer;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLKhachHang
    {
        DBMain db = null;

        public BLKhachHang()
        {
            db = new DBMain();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("select * from KhachHang", CommandType.Text);
        }
        public DataSet TimKiemKhachHang(string input, string key)
        {
            return db.ExecuteQueryDataSet("select * from KhachHang Where " + input + " like '%" + key+"%'", CommandType.Text);
        }
        public bool ThemKhachHang(string MaKhachHang, string TenKhachHang, string SoDienThoai, string DiaChi, ref string err)
        {
            string sqlString = "Insert Into KhachHang Values('" +
            MaKhachHang + "', N'" +
            TenKhachHang + "', N'" + SoDienThoai +"', N'" + DiaChi + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaKhachHang(ref string err, string MaKhachHang)
        {
            string sqlString = "Delete From KhachHang Where MaKhachHang='" + MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatKhachHang(string MaKhachHang, string TenKhachHang, string SoDienThoai, string DiaChi, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKhachHang=N'" +
            TenKhachHang +"', SoDienThoai= N'" + SoDienThoai + "', DiaChi= N'" + DiaChi + "' Where MaKhachHang='" + MaKhachHang + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
