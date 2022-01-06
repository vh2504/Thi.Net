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
    public partial class DanhMuc : Form
    {
        public DanhMuc()
        {
            InitializeComponent();
            NapDanhMuc();
        }

        void NapDanhMuc()
        {
            var ls = DanhMucBLL.GetListVM();
            danhMucVMBindingSource.DataSource = ls;
            dataGridView1.DataSource = danhMucVMBindingSource;
        }

        public DanhMucVM selectDanhMuc
        {
            get
            {
                return danhMucVMBindingSource.Current as DanhMucVM;
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (selectDanhMuc != null)
            {
                if (MessageBox.Show(
                    "Bạn có thực sự muốn xóa?",
                    "Chú ý", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DanhMucBLL.Delete(selectDanhMuc.MaDanhMuc);
                    danhMucVMBindingSource.RemoveCurrent();
                    MessageBox.Show("Đã xóa danh mục thành công");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new FrmChiTietDanhMuc();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDanhMuc();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectDanhMuc != null)
            {
                var f = new FrmChiTietDanhMuc(selectDanhMuc);
                var rs = f.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    NapDanhMuc();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var name = txtSearch.Text;
            var ls = DanhMucBLL.GetListByName(name);
            danhMucVMBindingSource.DataSource = ls;
            dataGridView1.DataSource = danhMucVMBindingSource;
        }
    }
}
