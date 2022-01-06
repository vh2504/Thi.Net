using QuanLyCuaHang.DAL;
using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.BLL
{
    public class SanPhamBLL
    {

        public static List<SanPhamVM> GetListVM()
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var ls = model.SanPham.Select(e => new SanPhamVM
            {
                MaSanPham = e.MaSanPham,
                TenSanPham = e.TenSanPham,
                Gia = (double) e.Gia,
                DonViTinh = e.DonViTinh,
                MoTa = e.MoTa,
                MaDanhMuc = (long)((long?)e.MaDanhMuc ?? 1)
            }).ToList();

            return ls;
        }

        public static List<SanPhamVM> GetListByName(string name)
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var ls = model.SanPham.Select(e => new SanPhamVM
            {
                MaSanPham = e.MaSanPham,
                TenSanPham = e.TenSanPham,
                Gia = (double)e.Gia,
                DonViTinh = e.DonViTinh,
                MoTa = e.MoTa,
                MaDanhMuc = (long)((long?)e.MaDanhMuc ?? 1)
            })
            .Where(s => s.TenSanPham.Contains(name))
            .ToList();

            return ls;
        }
        public static void Delete(long ID)
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var sanPham = model.SanPham.Where(e => e.MaSanPham == ID).FirstOrDefault();

            if (sanPham != null)
                model.SanPham.Remove(sanPham);
            else
            {
                throw new Exception("Sản phẩm không tồn tại");
            }
            model.SaveChanges();
        }

        public static int Add(SanPhamVM sanPhamVM)
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var sanpham = model.SanPham.Where(e => e.MaSanPham == sanPhamVM.MaSanPham).FirstOrDefault();
            if (sanpham != null)
            {
                return 1;
            }
            else
            {
                sanpham = new SanPham
                {
                    TenSanPham = sanPhamVM.TenSanPham,
                    Gia = sanPhamVM.Gia,
                    DonViTinh = sanPhamVM.DonViTinh,
                    MoTa = sanPhamVM.MoTa,
                    MaDanhMuc = sanPhamVM.MaDanhMuc
                };
                model.SanPham.Add(sanpham);
                model.SaveChanges();
                return 0;
            }
        }
        public static int Update(SanPhamVM sanPhamVM)
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var sanPham = model.SanPham.Where(e => e.MaSanPham != sanPhamVM.MaSanPham && e.TenSanPham == sanPhamVM.TenSanPham).FirstOrDefault();
            if (sanPham != null)
            {
                return 1;
            }
            else
            {
                sanPham = model.SanPham.Where(e => e.MaSanPham == sanPhamVM.MaSanPham).FirstOrDefault();
                sanPham.TenSanPham = sanPhamVM.TenSanPham;
                sanPham.Gia = sanPhamVM.Gia;
                sanPham.DonViTinh = sanPhamVM.DonViTinh;
                sanPham.MoTa = sanPhamVM.MoTa;
                sanPham.MaDanhMuc = sanPhamVM.MaDanhMuc;
                model.SaveChanges();
                return 0;
            }
        }
    }
}
