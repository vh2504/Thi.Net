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

    public partial class FrmChiTietSanPham : Form
    {
        SanPhamVM sanPhamVM;

        public FrmChiTietSanPham(SanPhamVM sanPhamVM = null)
        {
            InitializeComponent();
            this.sanPhamVM = sanPhamVM;

            var ls = DanhMucBLL.GetList();
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "TenDanhMuc";
            comboBox1.ValueMember = "MaDanhMuc";

            if (this.sanPhamVM == null)
            {
                this.Text = "Thêm mới sản phẩm";
            }
            else
            {
                this.Text = "Chỉnh sửa sản phẩm";
                txtTenSanPham.Text = sanPhamVM.TenSanPham;
                txtGia.Text = sanPhamVM.Gia.ToString();
                txtDonViTinh.Text = sanPhamVM.DonViTinh;
                txtMoTa.Text = sanPhamVM.MoTa;
                comboBox1.SelectedValue = sanPhamVM.MaDanhMuc;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tenSanPham = txtTenSanPham.Text;
            var gia = txtGia.Text;
            var donViTinh = txtDonViTinh.Text;
            var mota = txtMoTa.Text;
            var danhMuc = comboBox1.SelectedItem as DAL.DanhMuc;
            var danhMucID = danhMuc.MaDanhMuc;

            if (string.IsNullOrEmpty(tenSanPham))
            {
                errorProvider1.SetError(txtTenSanPham, "Tên không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(gia))
            {
                errorProvider1.SetError(txtGia, "Giá không được để trống");
                return;
            }

            var rs = 0;
            if (sanPhamVM == null)
            {
                //them moi
                rs = SanPhamBLL.Add(new SanPhamVM
                {
                    TenSanPham = tenSanPham,
                    Gia = Convert.ToDouble(txtGia.Text),
                    DonViTinh = donViTinh,
                    MoTa = mota,
                    MaDanhMuc = danhMucID
                }) ;
            }
            else
            {
                //cap nhat du lieu
                sanPhamVM.TenSanPham = tenSanPham;
                sanPhamVM.Gia = Convert.ToDouble(txtGia.Text);
                sanPhamVM.DonViTinh = donViTinh;
                sanPhamVM.MoTa = mota;
                sanPhamVM.MaDanhMuc = danhMucID;
                rs = SanPhamBLL.Update(sanPhamVM);
            }

            if (rs == 0)
            {
                DialogResult = DialogResult.OK;
            }
            else if (rs == 1)
            {
                MessageBox.Show("Mã sản phẩm không được trùng.", "Thông báo");
            }
        }
    }
}
