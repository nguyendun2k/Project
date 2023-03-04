namespace WebSach1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        public int Ma { get; set; }

        [StringLength(500)]
        public string Ten { get; set; }

        [StringLength(500)]
        public string GioiTinh { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(16)]
        public string DienThoai { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(500)]
        public string TenDangNhap { get; set; }

        [StringLength(500)]
        public string MatKhau { get; set; }

        [StringLength(500)]
        public string Anh { get; set; }

        [StringLength(500)]
        public string Quyen { get; set; }
    }
}
