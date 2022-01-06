using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyCuaHang.DAL
{
    public partial class QLCuaHangApp : DbContext
    {
        public QLCuaHangApp()
            : base("name=QLCuaHangApp")
        {
        }

        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           /* modelBuilder.Entity<DanhMuc>()
            .Property(f => f.MaDanhMuc)
            .ValueGeneratedOnAdd();*/
        }
    }
}
