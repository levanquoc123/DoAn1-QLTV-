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
    class BLquanlydocgia
    {
        DBmain db = null;
        public BLquanlydocgia()
        {
            db = new DBmain();
        }
        public DataSet LayDocGia()
        {
            return db.ExecuteQueryDataSet("select * from docgia", CommandType.Text);
        }
        public bool ThemDocGia(string madg, string tendangnhap, string tendocgia, string diachi, string sdt, ref string err)
        {

            string sqlString = "Insert Into docgia Values(" + "'" + madg + "','" + tendangnhap + "',N'" + tendocgia + "',N'" + diachi + "','" + sdt + "' )";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatDocGia(string tk, string mk, ref string err)
        {

            string sqlString = "Update taikhoan Set matkhau='" + mk + "' Where tendangnhap='" + tk + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool KiemTraDocGia(string tk)
        {
            string sqlString = "select * from taikhoan Where tendangnhap='" + tk + "'";
            return db.kiemtra(sqlString, CommandType.Text);
        }
        public bool XoaDocGia(ref string err, string tendangnhap)
        {
            string sqlString = "Delete From taikhoan Where tendangnhap='" + tendangnhap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
