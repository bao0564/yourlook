﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    [Table("DbChiTietDonHang")]
    public class DbChiTietDonHang:CmAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaCTDH {  get; set; }

        public int MaDh { get; set; }

        public int MaSp { get; set; }
        public string? TenSp { get; set; }
        public string? AnhSp { get; set; }
        public int? SoLuongSp { get; set; }

        public decimal Price { get; set; }

        //public virtual DbSanPham? MaSpNavigation { get; set; }

        [ForeignKey("MaDh")]
        public virtual DbDonHang MaDhNavigation { get; set; }
    }
}
