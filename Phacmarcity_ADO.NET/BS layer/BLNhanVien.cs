using Phacmarcity_ADO.NET.DB_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phacmarcity_ADO.NET.ENUM;

namespace Phacmarcity_ADO.NET.BS_layer
{
    class BLNhanVien
    {
        DBMain db = null;

        public BLNhanVien()
        {
            db = new DBMain();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text);
        }
        public DataSet TimKiemNhanVien(string input, string key)
        {
            if (input != nameof(Cls_Enum.OptionEmployee.NgaySinh)) 
            {
                return db.ExecuteQueryDataSet("select * from NhanVien Where " + input + " like '%" + key + "%'", CommandType.Text);
            }
            else
            {
                return db.ExecuteQueryDataSet("select * from NhanVien Where " + input + " = '" + key + "'", CommandType.Text);
            }
        }
        public bool ThemNhanVien(string MaNhanVien, string HoTen, DateTime NgaySinh, string BoPhan, string SoDienThoai, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values('" +
            MaNhanVien + "', N'" +
            HoTen + "', '" + NgaySinh + "', N'" + BoPhan + "', N'" + SoDienThoai + "')";

            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
        public bool XoaNhanVien(ref string err, string MaNhanVien)
        {
            string sqlString = "Delete From NhanVien Where MaNhanVien='" + MaNhanVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien(string MaNhanVien, string HoTen, DateTime NgaySinh, string BoPhan, string SoDienThoai, ref string err)
        {
            string sqlString = "Update NhanVien Set HoTen=N'" + HoTen + "', SoDienThoai= N'" + SoDienThoai + "', NgaySinh= '" + NgaySinh + "', BoPhan = N'" + BoPhan + "' Where MaNhanVien='" + MaNhanVien + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
