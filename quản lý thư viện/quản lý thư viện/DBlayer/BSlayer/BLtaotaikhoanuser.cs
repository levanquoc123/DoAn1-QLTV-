using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using quản_lý_thư_viện.DBlayer;

namespace quản_lý_thư_viện.BSlayer
{
    class BLtaotaikhoanuser
    {
        DBmain db = null;
        public BLtaotaikhoanuser()
        {
            db = new DBmain();
        }
        public DataSet LayNguoiDung()
        {
            return db.ExecuteQueryDataSet("select * from taikhoan", CommandType.Text);
        }
        public bool ThemNguoiDung(string tk, string mk, string quyendn, ref string err)
        {
            string sqlString = "Insert Into taikhoan Values(" + "'" + tk + "','" + mk + "','" + quyendn + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNguoiDung(string tk, string mk, ref string err)
        {

            string sqlString = "Update taikhoan Set matkhau='" + mk + "' Where tendangnhap='" + tk + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool KiemTraNguoiDung(string tk)
        {
            string sqlString = "select * from taikhoan Where tendangnhap='" + tk + "'";
            return db.kiemtra(sqlString, CommandType.Text);
        }
        public bool XoaNguoiDung(ref string err, string tendangnhap)
        {
            string sqlString = "Delete From taikhoan Where tendangnhap='" + tendangnhap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet LayNguoiDungUser(string user)
        {
            string sqlString = "select * from taikhoan where quyen = '" + user + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet LayNguoiDungAdmin(string admin)
        {
            string sqlString = "select * from taikhoan where quyen = '" + admin + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet LayTenNguoiDung(string ten)
        {
            string sqlString = "select * from taikhoan where tendangnhap = '" + ten + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
