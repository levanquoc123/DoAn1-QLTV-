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
    public partial class quanlysach : Form
    {
        DataTable dtquanlysach = null;         // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLquanlysach dbQLS = new BLquanlysach();
        BLnxb dbQLNXB = new BLnxb();
        BLtacgia dbQLTG = new BLtacgia();
        public quanlysach()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chaychu.Location = new Point(chaychu.Location.X + 1, chaychu.Location.Y);
            if (chaychu.Location.X > this.Width || chaychu.Location.X <= 0)
            {
                chaychu.Location = new Point(chaychu.Location.X - this.Width, chaychu.Location.Y);
            }
        }
        private void quanlysach_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LoadData();
        }

        //lấy dữ liệu sách
        public void LoadData()
        {
            try
            {
                dtquanlysach = new DataTable();
                dtquanlysach.Clear();
                DataSet ds = dbQLS.LaySach();
                dtquanlysach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtquanlysach;

            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }

        //chọn kiểu tìm
        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
            comboBox1.ResetText();
            comboBox1.Text = "Chọn Kiểu";
        }
        //thêm sách
        private void button1_Click(object sender, EventArgs e)
        {

            themsach ts = new themsach();
            this.Hide();
            ts.ShowDialog();

        }
        //xóa sách
        private void xoa_Click(object sender, EventArgs e)
        {
            try
            {

                int r = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành          
                string strquanlysach = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strquanlysach1 = dataGridView1.Rows[r].Cells[3].Value.ToString();
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp              
                traloi = MessageBox.Show("Bạn muốn xóa sách này?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?      
                if (traloi == DialogResult.Yes)
                {

                    dbQLS.XoaSach(ref err, strquanlysach);
                    dbQLNXB.XoaNXB(ref err, strquanlysach1);
                    dbQLTG.XoaTacGia(ref err, strquanlysach);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    MessageBox.Show("Không thực hiện việc xóa!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        //tìm kiếm
        private void timkiem_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Mã Sách")
            {

                dtquanlysach = new DataTable();
                dtquanlysach.Clear();
                DataSet ds = dbQLS.timmasach(this.textBox1.Text);
                dtquanlysach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtquanlysach;
            }


            if (comboBox1.Text == "Tựa Đề")
            {
                dtquanlysach = new DataTable();
                dtquanlysach.Clear();
                DataSet ds = dbQLS.timtuade(this.textBox1.Text);
                dtquanlysach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtquanlysach;
            }

            if (comboBox1.Text == "Thể Loại")
            {
                dtquanlysach = new DataTable();
                dtquanlysach.Clear();
                DataSet ds = dbQLS.timtheloai(this.textBox1.Text);
                dtquanlysach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtquanlysach;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            thongtinchitiet ttct = new thongtinchitiet();
            ttct.xemmasach.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ttct.xemtuade.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ttct.xemtheloai.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            ttct.xemmanxb.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ttct.xemsoluong.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            ttct.xemvitri.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            ttct.ShowDialog();
        }

        //thoát
        private void quaylai_Click(object sender, EventArgs e)
        {

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
                //Application.Exit();
                this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
