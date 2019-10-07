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
    class BLnxb
    {
        DBmain db = null;
        public BLnxb()
        {
            db = new DBmain();
        }
        public DataSet LayNXB()
        {
            return db.ExecuteQueryDataSet("select * from tacgia", CommandType.Text);
        }
        public bool ThemNXB(string manxb, string tennxb, string diachi, string sdt, ref string err)
        {
            string sqlString = "Insert Into nxb Values(" + "'" + manxb + "',N'" + tennxb + "',N'" + diachi + "','" + sdt + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNXB(ref string err, string manxb)
        {
            string sqlString = "Delete From nxb Where manxb='" + manxb + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNXB(string manxb, string tennxb, string diachi, string sdt, ref string err)
        {
            string sqlString = "Update nxb Set tennxb=N'" + tennxb + "',diachi=N'" + diachi + "',sdt='" + sdt + "'Where manxb='" + manxb + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayMaNXBCuaTableNXB(string manxb)
        {
            string sqlString = "select * from nxb where manxb = '" + manxb + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
