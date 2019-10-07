using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_thư_viện
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
       
        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlysach qls = new quanlysach();
            qls.ShowDialog();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlyuser qlus = new quanlyuser();
            qlus.ShowDialog();
        }

        private void tạoTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlyadmin qlad = new quanlyadmin();
            qlad.ShowDialog();
        }

        private void thôngBáoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hotro ht = new hotro();
            ht.ShowDialog();
        }
    }
}
