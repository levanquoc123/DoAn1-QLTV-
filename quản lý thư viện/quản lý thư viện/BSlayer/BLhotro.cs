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
    class BLhotro
    {
        DBmain db = null;
        public BLhotro()
        {
            db = new DBmain();
        }
        public DataSet Laytt()
        {

            return db.ExecuteQueryDataSet("select * from thongbao", CommandType.Text);
        }
        public bool Themtt(string sott, string yeucau, ref string err)
        {
            string sqlString = "Insert Into thongbao Values(" + "'" + sott + "',N'" + yeucau + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool Xoatt(ref string err, string sott)
        {
            string sqlString = "Delete From thongbao Where sothutu='" + sott + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
