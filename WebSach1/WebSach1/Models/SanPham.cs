namespace WebSach1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        public int Ma { get; set; }

        [StringLength(500)]
        public string Ten { get; set; }

        [StringLength(500)]
        public string Mota { get; set; }

        public int MaLoai { get; set; }

        [StringLength(500)]
        public string Anh { get; set; }

        [Column(TypeName = "ntext")]
        public string Chitiet { get; set; }

        public int? TieuBieu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Gia { get; set; }

        [StringLength(50)]
        public string TacGia { get; set; }

        [StringLength(500)]
        public string NhaXuatBan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamXB { get; set; }

        [StringLength(50)]
        public string GiamGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }
    }
}
