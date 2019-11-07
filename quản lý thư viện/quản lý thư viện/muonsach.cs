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
    public partial class muonsach : Form
    {
        DataTable dtdocgia = null;
        BLdocgia blDG = new BLdocgia();
        DataTable dtquanlysach = null;
        BLquanlysach dbQLS = new BLquanlysach();
        DataTable dtquanlytacgia = null;
        BLtacgia dttg = new BLtacgia();
        DataTable dtmuonsach = null;
        BLmuonsach dbms = new BLmuonsach();
        string err;

        public muonsach()
        {
            InitializeComponent();
        }

        private void muonsach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.muonsach' table. You can move, or remove it, as needed.

            hienthitendangnhap.Text = dangnhap.tenhienthi;
            LoadData1();
            LoadData2();
            LoadData4();
            matudong.Text = tangmatudong();
            LoadData5();
         //   this.reportViewer1.Hide();
        }
        public void LoadData1()
        {
            try
            {

                dtdocgia = new DataTable();
                dtdocgia.Clear();
                //DataSet ds1 = dbQLTG.LayTacGia();
                DataSet ds1 = blDG.LayDocGiatheotendangnhap(hienthitendangnhap.Text);
               dtdocgia = ds1.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView4.DataSource = dtdocgia;
               // laymadocgia.Text = this.dataGridView4.CurrentRow.Cells[0].Value.ToString();


            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }
        public void LoadData2()
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
        public void LoadData3()
        {
            try
            {
                dtquanlytacgia = new DataTable();
                dtquanlytacgia.Clear();
                DataSet ds = dttg.LayMaSachCuaTableTacGia(laymasach.Text);

                dtquanlytacgia = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView3.DataSource = dtquanlytacgia;
                laytentacgia.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();


            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }
        public void LoadData4()
        {
            try
            {
                dtmuonsach = new DataTable();
                dtmuonsach.Clear();
                DataSet ds = dbms.LayMDG(laymadocgia.Text);

                dtmuonsach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView2.DataSource = dtmuonsach;
                //laytentacgia.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();


            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }
        public void LoadData5()
        {
            try
            {
                dtmuonsach = new DataTable();
                dtmuonsach.Clear();
                DataSet ds = dbms.LaySach();

                dtmuonsach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView5.DataSource = dtmuonsach;
                //laytentacgia.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();


            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }
        int k;
        int t;
        int h;

        //tính ngày nếu có quá hạn
        public void tinhngay()
        {
            DateTime d2 = Convert.ToDateTime(ngayhethong.Text);
            DateTime d1 = Convert.ToDateTime(ngaytra.Text);
            TimeSpan t = d2.Subtract(d1);
            int day = t.Days;
            //Convert.ToString(day);
            songayquahan.Text = day.ToString();

        }
 
       
        public string tangmatudong()
        {
            dtmuonsach = new DataTable();
            dtmuonsach.Clear();
            DataSet ds = dbms.LaySach();
            dtmuonsach = ds.Tables[0];
            string ma = " ";
            if (ds.Tables[0].Rows.Count <= 0)
            {
                ma = "ST001";
            }
            else
            {
                int k;
                ma = "ST";
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

        
        
        private void timkiem_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mã Sách")
            {

                dtquanlysach = new DataTable();
                dtquanlysach.Clear();
                DataSet ds = dbQLS.timmasach(this.textBox3.Text);
                dtquanlysach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtquanlysach;
            }


            if (comboBox1.Text == "Tựa Đề")
            {
                dtquanlysach = new DataTable();
                dtquanlysach.Clear();
                DataSet ds = dbQLS.timtuade(this.textBox3.Text);
                dtquanlysach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtquanlysach;
            }

            if (comboBox1.Text == "Thể Loại")
            {
                dtquanlysach = new DataTable();
                dtquanlysach.Clear();
                DataSet ds = dbQLS.timtheloai(this.textBox3.Text);
                dtquanlysach = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView1.DataSource = dtquanlysach;

            }
        }

        private void themsach_Click_1(object sender, EventArgs e)
        {
            t = Convert.ToInt32(laysoluong.Text);
            if (t <= 0)
            {
                MessageBox.Show("ko dc muon!");
            }
            else
            {
                BLquanlysach dbQLS1 = new BLquanlysach();
                BLmuonsach dbms1 = new BLmuonsach();
                k = t - 1;
                dbQLS1.CapNhatSach(laymasach.Text, laytuade.Text, laytheloai.Text, laymanxb.Text, Convert.ToString(k), layvitri.Text, ref err);
                tinhngay();
                dbms1.ThemSach(laymadocgia.Text, laymasach.Text, laytuade.Text, laytentacgia.Text, Convert.ToString(1), ngaymuon.Text, ngaytra.Text, songayquahan.Text, matudong.Text, ref err);
                LoadData2();    
                LoadData4();
                matudong.Text = tangmatudong();
                LoadData5();
            }
        }

        

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.reportViewer1.Hide();
             DialogResult traloi;
                traloi = MessageBox.Show("Bạn Thực Sự Muốn Thoát?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (traloi == DialogResult.Yes)
                    Application.Exit();
        }
        DataTable dtquanlysach1 = null;
        BLquanlysach dbQLS1 = new BLquanlysach();
        public void LoadData6()
        {
            try
            {
                dtquanlysach1 = new DataTable();
                dtquanlysach1.Clear();
                DataSet ds = dbQLS1.timmasach(laymsach.Text);

                dtquanlysach1 = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView       
                dataGridView6.DataSource = dtquanlysach1;
                //laytentacgia.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();


            }

            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NguoiDung. Lỗi rồi!!!");
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            this.reportViewer1.Show();
            //this.muonsachTableAdapter.Fill(this.DataSet1.muonsach, laymadocgia.Text);
            this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            laymasach.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            laytuade.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            laytheloai.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            laymanxb.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            laysoluong.Text = dataGridView1.Rows[r].Cells[4].Value.ToString();
            layvitri.Text = dataGridView1.Rows[r].Cells[5].Value.ToString();
            
            LoadData3();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView2.CurrentCell.RowIndex;
            laymsach.Text = dataGridView2.Rows[r].Cells[2].Value.ToString();
            laytde.Text = dataGridView2.Rows[r].Cells[3].Value.ToString();
            LoadData6();
            laytloai.Text = this.dataGridView6.CurrentRow.Cells[2].Value.ToString();
            laymnxb.Text = this.dataGridView6.CurrentRow.Cells[3].Value.ToString();
            layvtri.Text = this.dataGridView6.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BLmuonsach dbMS2 = new BLmuonsach();
                BLquanlysach dbQLS2 = new BLquanlysach();
                k = Convert.ToInt32(this.dataGridView6.CurrentRow.Cells[4].Value.ToString());
                int r = dataGridView2.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành          
                string strquanlysach = dataGridView2.Rows[r].Cells[0].Value.ToString();
                dbMS2.XoaSach(ref err, strquanlysach);
                h = k + 1;
                dbQLS2.CapNhatSach(laymsach.Text, laytde.Text, laytloai.Text, laymnxb.Text, Convert.ToString(h), layvtri.Text, ref err);
                LoadData2();
                LoadData4();
                LoadData5();
                LoadData6();
                MessageBox.Show("TRẢ THANH CONG!");
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
