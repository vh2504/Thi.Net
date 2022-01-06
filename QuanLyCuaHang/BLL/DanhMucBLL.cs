using QuanLyCuaHang.DAL;
using QuanLyCuaHang.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.BLL
{
    class DanhMucBLL
    {

        public static List<DAL.DanhMuc> GetList()
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var ls = model.DanhMuc.ToList();
            return ls;
        }

        public static List<DanhMucVM> GetListByName(string name)
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var ls = model.DanhMuc.Select(e => new DanhMucVM
            {
                MaDanhMuc = e.MaDanhMuc,
                TenDanhMuc = e.TenDanhMuc,
                MoTa = e.MoTa
            })
             .Where(s => s.TenDanhMuc.Contains(name))
             .ToList();

            return ls;
        }

        public static List<DanhMucVM> GetListVM()
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var ls = model.DanhMuc.Select(e => new DanhMucVM
            {
                MaDanhMuc = e.MaDanhMuc,
                TenDanhMuc = e.TenDanhMuc,
                MoTa = e.MoTa
            }).ToList();
            return ls;
        }

        public static void Delete(long maDanhMuc)
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var danhMuc = model.DanhMuc.Where(e => e.MaDanhMuc == maDanhMuc).FirstOrDefault();
            if (danhMuc.SanPham.Count() > 0)
            {
                throw new Exception("Danh mục này đã tồn tại sản phẩm. Vui lòng kiểm tra lại");
            }
            if (danhMuc != null)
                model.DanhMuc.Remove(danhMuc);
            else
            {
                throw new Exception("Danh mục không tồn tại");
            }
            model.SaveChanges();
        }

        public static int Add(DanhMucVM danhMucVM)
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var danhMuc = model.DanhMuc.Where(e => e.TenDanhMuc == danhMucVM.TenDanhMuc).FirstOrDefault();
            if (danhMuc != null)
            {
                return 1;
            }
            else
            {
                danhMuc = new DAL.DanhMuc
                {
                    TenDanhMuc = danhMucVM.TenDanhMuc,
                    MoTa = danhMucVM.MoTa
                };
                model.DanhMuc.Add(danhMuc);
                model.SaveChanges();
                return 0;

            }
        }

        public static int Update(DanhMucVM danhMucVM)
        {
            QLCuaHangApp model = new QLCuaHangApp();
            var danhMuc = model.DanhMuc.Where(e => e.MaDanhMuc != danhMucVM.MaDanhMuc && e.TenDanhMuc == danhMucVM.TenDanhMuc).FirstOrDefault();

            if (danhMuc != null)
            {
                return 1;
            }
            else
            {
                danhMuc = model.DanhMuc.Where(e => e.MaDanhMuc == danhMucVM.MaDanhMuc).FirstOrDefault();
                danhMuc.TenDanhMuc = danhMucVM.TenDanhMuc;
                danhMuc.MoTa = danhMucVM.MoTa;
                model.SaveChanges();
                return 0;
            }
        }
    }
 }
