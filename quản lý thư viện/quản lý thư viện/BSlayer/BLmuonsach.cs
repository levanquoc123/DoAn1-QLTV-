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
    class BLmuonsach
    {
        DBmain db = null;
        public BLmuonsach()
        {
            db = new DBmain();
        }
        public DataSet LaySach()
        {
            return db.ExecuteQueryDataSet("select * from muonsach", CommandType.Text);
        }
        public DataSet LayMDG(string mdg)
        {
            string sqlString = "select * from muonsach where madocgia = '" + mdg + "'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public bool ThemSach(string madocgia, string masach, string tensach, string tentacgia, string soluong, string ngaymuon, string ngaytra, string songay, string stt, ref string err)
        {
            string sqlString = "Insert Into muonsach Values(" + "'" + stt + "','" + madocgia + "','" + masach + "',N'" + tensach + "',N'" + tentacgia + "','" + soluong + "','" + ngaymuon + "','" + ngaytra + "','" + songay + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSach(ref string err, string masach)
        {
            string sqlString = "Delete From muonsach Where sothutu='" + masach + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSach(string madocgia, string masach, string tensach, string tentacgia, string soluong, string ngaymuon, string ngaytra, string songay, string stt, ref string err)
        {
            string sqlString = "Update muonsach Set madocgia='" + madocgia + "',tensach=N'" + tensach + "',tentacgia=N'" + tentacgia + "',soluong='" + soluong + "',ngaymuon='" + ngaymuon + "',ngaytra='" + ngaytra + "',songayquahan='" + songay + "',sothutu='" + stt + "'Where masach='" + masach + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSoNgayTraSach(int songayphaitra, string stt, ref string err)
        {
            string sqlString = "Update muonsach Set songayquahan='" + songayphaitra + "'Where sothutu='" + stt + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool LayMS(string mdg)
        {
            string sqlString = "select * from muonsach where masach = '" + mdg + "'";
            return db.kiemtra(sqlString, CommandType.Text);
        }
        public bool Laydg(string mdg)
        {
            string sqlString = "select * from muonsach where madocgia = '" + mdg + "'";
            return db.kiemtra(sqlString, CommandType.Text);
        }

        public DataSet timmasach(string nhapmasach)
        {
            //string sqlString = "select * from cuonsach where masach like'%" + nhapmasach + "%'";
            return db.ExecuteQueryDataSet("select * from muonsach where masach like'%" + nhapmasach + "%'", CommandType.Text);
        }
        public DataSet timtuade(string nhaptuade)
        {
            string sqlString = "select * from muonsach where tuade like N'%" + nhaptuade + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public DataSet timtheloai(string nhaptheloai)
        {
            string sqlString = "select * from muonsach where theloai like N'%" + nhaptheloai + "%'";
            return db.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
