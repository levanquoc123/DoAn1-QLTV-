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
    public partial class thongtinchitiet : Form
    {
        DataTable dtquanlytacgia = null;         // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        bool Them;
        string err;
        BLtacgia dbQLTG = new BLtacgia();

        DataTable dtquanlynxb = null;
        BLnxb dbQLNXB = new BLnxb();
        BLquanlysach dbQLS = new BLquanlysach();
        public thongtinchitiet()
        {
            InitializeComponent();
        }

        private void thongtinchitiet_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dataGridView1.Hide();
            dataGridView2.Hide();
            Loadtacgia();
            Loadnxb();
            tinhtrangtextbox();
        }

        //lấy tác giả theo mã
        public void Loadtacgia()
        {
            try
            {
                dtquanlytacgia = new DataTable();
                dtquanlytacgia.Clear();
                DataSet ds = dbQLTG.LayMaSachCuaTableTacGia(this.xemmasach.Text);
                dtquanlytacgia = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtquanlytacgia;
                xemtentacgia.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();



            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }

        //lấy nhà xuất  bản
        public void Loadnxb()
        {
            try
            {



                dtquanlynxb = new DataTable();
                dtquanlynxb.Clear();
                DataSet ds1 = dbQLNXB.LayMaNXBCuaTableNXB(this.xemmanxb.Text);
                dtquanlynxb = ds1.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView2.DataSource = dtquanlynxb;
                // xemmanxb.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
                xemtennxb.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
                xemdiachi.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
                xemsdt.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chaychu.Location = new Point(chaychu.Location.X + 1, chaychu.Location.Y);
            if (chaychu.Location.X > this.Width || chaychu.Location.X <= 0)
            {
                chaychu.Location = new Point(chaychu.Location.X - this.Width, chaychu.Location.Y);
            }
        }
        //hủy
        private void huy_Click(object sender, EventArgs e)
        {
            tinhtrangtextbox();
        }

        public void tinhtrangtextbox()
        {
            xemdiachi.Enabled = false;
            xemmanxb.Enabled = false;
            xemmasach.Enabled = false;
            xemsdt.Enabled = false;
            xemsoluong.Enabled = false;
            xemtennxb.Enabled = false;
            xemtentacgia.Enabled = false;
            xemtheloai.Enabled = false;
            xemtuade.Enabled = false;
            xemvitri.Enabled = false;
        }
        //sửa
        private void sua_Click(object sender, EventArgs e)
        {
            Them = true;
            xemdiachi.Enabled = true;
            xemsdt.Enabled = true;
            xemsoluong.Enabled = true;
            xemtennxb.Enabled = true;
            xemtentacgia.Enabled = true;
            xemtheloai.Enabled = true;
            xemtuade.Enabled = true;
            xemvitri.Enabled = true;
            xemtuade.Focus();
        }
        //lưu
        private void luu_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                dbQLTG.CapNhatTacGia(this.xemmasach.Text, this.xemtentacgia.Text, ref err);
                dbQLNXB.CapNhatNXB(this.xemmanxb.Text, this.xemtennxb.Text, this.xemdiachi.Text, this.xemsdt.Text, ref err);
                dbQLS.CapNhatSach(this.xemmasach.Text, this.xemtuade.Text, this.xemtheloai.Text, this.xemmanxb.Text, this.xemsoluong.Text, this.xemvitri.Text, ref err);
                MessageBox.Show("Đã sửa xong!");
            }
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
    }
}
