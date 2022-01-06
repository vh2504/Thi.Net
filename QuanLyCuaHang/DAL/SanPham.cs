namespace QuanLyCuaHang.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MaSanPham { get; set; }

        [StringLength(250)]
        public string TenSanPham { get; set; }

        public double? Gia { get; set; }

        [StringLength(250)]
        public string DonViTinh { get; set; }

        [StringLength(250)]
        public string MoTa { get; set; }

        public long? MaDanhMuc { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}
