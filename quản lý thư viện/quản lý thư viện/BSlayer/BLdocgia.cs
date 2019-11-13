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
    class BLdocgia
    {
        DBmain db = null;
        public BLdocgia()
        {
            db = new DBmain();
        }
        public DataSet LayDocGia()
        {

            return db.ExecuteQueryDataSet("select * from docgia", CommandType.Text);
        }
        //public bool ThemTacGia(string masach, string tentacgia, ref string err)
        //{
        //    string sqlString = "Insert Into tacgia Values(" + "'" + masach + "',N'" + tentacgia + "')";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}
        //public bool XoaTacGia(ref string err, string masach)
        //{
        //    string sqlString = "Delete From tacgia Where masach='" + masach + "'";
        //    return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        //}
        public bool CapNhatDocGia(string madg, string tendg, string diachi, string sdt, string tendn, ref string err)
        {
            string sqlString = "Update docgia Set tendangnhap='" + tendn + "',tendocgia=N'" + tendg + "',diachi=N'" + diachi + "',sdt='" + sdt + "'Where madocgia='" + madg + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet LayDocGiatheotendangnhap(string tendn)
        {
            string sqlString = "select * from docgia where tendangnhap = '" + tendn + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
