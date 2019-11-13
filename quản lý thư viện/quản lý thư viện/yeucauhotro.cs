using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quản_lý_thư_viện.BSlayer;
using System.Data.SqlClient;
namespace quản_lý_thư_viện
{
    public partial class yeucauht : Form
    {
        DataTable dthotro = null;
        BLhotro blht = new BLhotro();
        string err;
        public yeucauht()
        {
            InitializeComponent();
        }

        private void yeucauht_Load(object sender, EventArgs e)
        {
            Loaddata();
        }
        //lấy dữ liệu để tăng mã số thứ tự
        public void Loaddata()
        {
            try
            {
                dthotro = new DataTable();
                dthotro.Clear();
                DataSet ds = blht.Laytt();
                dthotro = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       

                textBox2.Text = tangmatudong();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }
        //Gửi yêu cầu
        private void button1_Click(object sender, EventArgs e)
        {
            blht.Themtt(textBox2.Text, textBox1.Text, ref err);
            Loaddata();
            // Thông báo            
            MessageBox.Show("Gửi thành công!");

        }

        //tăng mã tự động
        public string tangmatudong()
        {
            dthotro = new DataTable();
            dthotro.Clear();
            DataSet ds = blht.Laytt();
            dthotro = ds.Tables[0];
            string ma = "";
            if (ds.Tables[0].Rows.Count <= 0)
            {
                ma = "HT001";
            }
            else
            {
                int k;
                ma = "HT";
                k = Convert.ToInt32(ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";

                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }

        //private void yeucauht_Load_1(object sender, EventArgs e)
        //{
        //    Loaddata();
        //}
    }
}
