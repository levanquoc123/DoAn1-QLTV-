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
    class BLquanlysach
    {
        DBmain db = null;
        public BLquanlysach()
        {
            db = new DBmain();
        }
        public DataSet LaySach()
        {
            return db.ExecuteQueryDataSet("select * from cuonsach", CommandType.Text);
        }
        public bool ThemSach(string masach, string tuade, string theloai, string manxb, string soluong, string vitri, ref string err)
        {
            string sqlString = "Insert Into cuonsach Values(" + "'" + masach + "',N'" + tuade + "',N'" + theloai + "','" + manxb + "','" + soluong + "','" + vitri + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSach(ref string err, string masach)
        {
            string sqlString = "Delete From cuonsach Where masach='" + masach + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSach(string masach, string tuade, string theloai, string manxb, string soluong, string vitri, ref string err)
        {
            string sqlString = "Update cuonsach Set tuade=N'" + tuade + "',theloai=N'" + theloai + "',manxb='" + manxb + "',soluong='" + soluong + "',vitri='" + vitri + "'Where masach='" + masach + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet timmasach(string nhapmasach)
        {
            //string sqlString = "select * from cuonsach where masach like'%" + nhapmasach + "%'";
            return db.ExecuteQueryDataSet("select * from cuonsach where masach like'%" + nhapmasach + "%'", CommandType.Text);
        }
        public DataSet timtuade(string nhaptuade)
        {
            string sqlString = "select * from cuonsach where tuade like N'%" + nhaptuade + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet timtheloai(string nhaptheloai)
        {
            string sqlString = "select * from cuonsach where theloai like N'%" + nhaptheloai + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
