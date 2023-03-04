namespace WebSach1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        [Key]
        public int Ma { get; set; }

        [StringLength(500)]
        public string TieuDe { get; set; }

        [StringLength(500)]
        public string MoTaNgan { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        [StringLength(500)]
        public string Anh { get; set; }

        public int MaCM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDang { get; set; }

        [StringLength(50)]
        public string TacGia { get; set; }

        public virtual ChuyenMuc ChuyenMuc { get; set; }
    }
}
