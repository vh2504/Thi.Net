using QuanLyCuaHang.BLL;
using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
            NapSanPham();

        }

        void NapSanPham()
        {
            var ls = SanPhamBLL.GetListVM();
            sanPhamVMBindingSource.DataSource = ls;
            dataGridView1.DataSource = sanPhamVMBindingSource;
        }
        public SanPhamVM selectSanPham
        {
            get
            {
                return sanPhamVMBindingSource.Current as SanPhamVM;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (selectSanPham != null)
            {
                if (MessageBox.Show(
                    "Bạn có thực sự muốn xóa?",
                    "Chú ý", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SanPhamBLL.Delete(selectSanPham.MaSanPham);
                    sanPhamVMBindingSource.RemoveCurrent();
                    MessageBox.Show("Đã xóa sản phẩm thành công");
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var f = new FrmChiTietSanPham();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapSanPham();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (selectSanPham != null)
            {
                var f = new FrmChiTietSanPham(selectSanPham);
                var rs = f.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    NapSanPham();
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var name = txtSearch.Text;
            var ls = SanPhamBLL.GetListByName(name);
            sanPhamVMBindingSource.DataSource = ls;
            dataGridView1.DataSource = sanPhamVMBindingSource;
        }
    }
}
