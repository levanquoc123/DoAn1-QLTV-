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
    public partial class chitietsachchomuon : Form
    {
        DataTable dtdocgia = null;
        BLdocgia dbDG = new BLdocgia();
        DataTable dtmuonsach1 = null;
        BLmuonsach dbMS = new BLmuonsach();
        public chitietsachchomuon()
        {
            InitializeComponent();
        }
        public static string tenht = "";
        private void chitietsachchomuon_Load(object sender, EventArgs e)
        {
            LoadData2();
            LoadData3();
            timer1.Enabled = true;
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tenht = textBox2.Text;
        }
        public void LoadData2()
        {
            try
            {


                dtdocgia = new DataTable();
                dtdocgia.Clear();
                //DataSet ds1 = dbQLTG.LayTacGia();
                DataSet ds1 = dbDG.LayDocGiatheotendangnhap(hienthimadocgia.Text);
                dtdocgia = ds1.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView4.DataSource = dtdocgia;
                textBox1.Text = this.dataGridView4.CurrentRow.Cells[0].Value.ToString();


            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }
        public void LoadData3()
        {
            try
            {
                dtmuonsach1 = new DataTable();
                dtmuonsach1.Clear();
                DataSet ds = dbMS.LayMDG(this.textBox1.Text);

                dtmuonsach1 = ds.Tables[0];
                // dtmuonsach1.Columns.RemoveAt(0);
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtmuonsach1;
                hienthitendocgia.Text = this.dataGridView4.CurrentRow.Cells[2].Value.ToString();
                hienthidiachi.Text = this.dataGridView4.CurrentRow.Cells[3].Value.ToString();
                hienthisdt.Text = this.dataGridView4.CurrentRow.Cells[4].Value.ToString();
                //  hienthitienno.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();

            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }
        int tongtien;
        string dg = "VNĐ";
        public void tinhtien()
        {
            int k = Convert.ToInt32(hienthitienno.Text);
            tongtien = k * 1000;
            tienno.Text = Convert.ToString(tongtien) + dg;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            chaychu.Location = new Point(chaychu.Location.X + 1, chaychu.Location.Y);
            if (chaychu.Location.X > this.Width || chaychu.Location.X <= 0)
            {
                chaychu.Location = new Point(chaychu.Location.X - this.Width, chaychu.Location.Y);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Tho?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
                //Application.Exit();
                this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel         
            hienthitienno.Text = dataGridView1.Rows[r].Cells[8].Value.ToString();
            tinhtien(); 
        }

        private void hienthimadocgia_Click(object sender, EventArgs e)
        {

        }
    }
}
