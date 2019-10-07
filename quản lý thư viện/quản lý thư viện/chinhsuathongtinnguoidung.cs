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
    public partial class chinhsuathongtinnguoidung : Form
    {
        DataTable dtdocgia = null;
        BLdocgia dbDG = new BLdocgia();
        string err;
        public chinhsuathongtinnguoidung()
        {
            InitializeComponent();
        }

        private void chinhsuathongtinnguoidung_Load(object sender, EventArgs e)
        {
            LoadData2();
        }

        //lấy dữ liệu của user tương ứng với tendangnhap 
        public void LoadData2()
        {
            try
            {

                dangnhap dn = new dangnhap();
                textBox4.Text = dangnhap.tenhienthi;
                dtdocgia = new DataTable();
                dtdocgia.Clear();
                //DataSet ds1 = dbQLTG.LayTacGia();
                DataSet ds1 = dbDG.LayDocGiatheotendangnhap(textBox4.Text);
                dtdocgia = ds1.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtdocgia;
                coidiachi.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                coisdt.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                coitendocgia.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }

        

        private void coitendocgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbDG.CapNhatTacGia(this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), coitendocgia.Text, coidiachi.Text, coisdt.Text, this.dataGridView1.CurrentRow.Cells[1].Value.ToString(), ref err);
            LoadData2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
                //Application.Exit();
                this.Close();
        }
    }
}
