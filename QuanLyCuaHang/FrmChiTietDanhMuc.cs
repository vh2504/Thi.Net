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
    public partial class FrmChiTietDanhMuc : Form
    {
        DanhMucVM danhMucVM;
        public FrmChiTietDanhMuc(DanhMucVM danhMucVM = null)
        {
            InitializeComponent();
            this.danhMucVM = danhMucVM;
            if (this.danhMucVM == null)
            {
                this.Text = "Thêm mới danh mục";
            }
            else
            {
                this.Text = "Chỉnh sửa danh mục";
                txtTenDanhMuc.Text = danhMucVM.TenDanhMuc;
                txtMoTa.Text = danhMucVM.MoTa;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tenDanhMuc = txtTenDanhMuc.Text;
            var moTa = txtMoTa.Text;
            if (string.IsNullOrEmpty(tenDanhMuc))
            {
                errorProvider1.SetError(txtTenDanhMuc, "Tên danh mục không được để trống");
                return;
            }
            var rs = 0;
            if (danhMucVM == null)
            {
                //them moi
                rs = DanhMucBLL.Add(new DanhMucVM { TenDanhMuc = tenDanhMuc, MoTa = moTa });
            }
            else
            {
                //cap nhat du lieu\
                danhMucVM.TenDanhMuc = tenDanhMuc;
                danhMucVM.MoTa = moTa;
                rs = DanhMucBLL.Update(danhMucVM);
            }
            if (rs == 0)
            {
                DialogResult = DialogResult.OK;
            }
            else if (rs == 1)
            {
                MessageBox.Show("Tên danh mục không được trùng nhau", "Thông báo");
            }
        }
    }
}
