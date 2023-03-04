namespace WebSach1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CauHinh")]
    public partial class CauHinh
    {
        [Key]
        public int Ma { get; set; }

        [StringLength(500)]
        public string Logo { get; set; }

        [StringLength(500)]
        public string CongTy { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(16)]
        public string SoDienThoai { get; set; }

        [StringLength(500)]
        public string Banner1 { get; set; }

        [StringLength(500)]
        public string Banner2 { get; set; }

        [StringLength(500)]
        public string Banner3 { get; set; }

        [StringLength(500)]
        public string Banner4 { get; set; }

        [StringLength(500)]
        public string Email { get; set; }
    }
}
