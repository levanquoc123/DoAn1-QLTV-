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
    public partial class hotro : Form
    {
        DataTable dthotro = null;
        BLhotro blht = new BLhotro();
        string err;
        public hotro()
        {
            InitializeComponent();
        }

        private void hotro_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Loaddata();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chaychu.Location = new Point(chaychu.Location.X + 1, chaychu.Location.Y);
            if (chaychu.Location.X > this.Width || chaychu.Location.X <= 0)
            {
                chaychu.Location = new Point(chaychu.Location.X - this.Width, chaychu.Location.Y);
            }
        }

        //lấy dữ liệu từ table thongbao
        public void Loaddata()
        {
            try
            {
                dthotro = new DataTable();
                dthotro.Clear();
                DataSet ds = blht.Laytt();
                dthotro = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dthotro;




            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }


        //thoát
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
                //Application.Exit();
                this.Close();
        }

        //xóa
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh             
                // Lấy thứ tự record hiện hành              

                int r = dataGridView1.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành          
                string strHoaDon = dataGridView1.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL  

                // Hiện thông báo xác nhận việc xóa mẫu tin         
                // Khai báo biến traloi                 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp              
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?      
                if (traloi == DialogResult.Yes)
                {

                    blht.Xoatt(ref err, strHoaDon);

                    // Cập nhật lại DataGridView        
                    Loaddata();
                    // Thông báo                    
                    MessageBox.Show("Đã gửi xong!");
                }
                else
                {
                    // Thông báo         
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không gửi được. Lỗi rồi!");
            }
        }
    }
}
