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
    class BLkiemtratk
    {
        DBmain db = new DBmain();
        public BLkiemtratk()
        {
            db = new DBmain();
        }
        public bool ktratk(string tk, string mk, string quyendn)
        {
            string sqlString = "select * from taikhoan Where tendangnhap='" + tk + "'and matkhau='" + mk + "'and quyen='" + quyendn + "'";
            return db.kiemtra(sqlString, CommandType.Text);
        }
    }
}
