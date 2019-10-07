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
    class BLtacgia
    {
        DBmain db = null;
        public BLtacgia()
        {
            db = new DBmain();
        }
        public DataSet LayTacGia()
        {
            return db.ExecuteQueryDataSet("select * from tacgia", CommandType.Text);
        }
        public bool ThemTacGia(string masach, string tentacgia, ref string err)
        {
            string sqlString = "Insert Into tacgia Values(" + "'" + masach + "',N'" + tentacgia + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaTacGia(ref string err, string masach)
        {
            string sqlString = "Delete From tacgia Where masach='" + masach + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatTacGia(string masach, string tentacgia, ref string err)
        {
            string sqlString = "Update tacgia Set tentacgia=N'" + tentacgia + "'Where masach='" + masach + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet LayMaSachCuaTableTacGia(string masach)
        {
            string sqlString = "select * from tacgia where masach = '" + masach + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
