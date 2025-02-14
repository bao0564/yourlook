﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Data.Models
{
    [Table("DbKhachHang")]
    public class DbKhachHang:CmAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKh { get; set; }
        [Required(ErrorMessage = "Tên không được để trống")]
        public string TenKh { get; set; }

        public string? Img { get; set; }

        public string? GioiTinh { get; set; }

        public string? Addres { get; set; }


        [Required(ErrorMessage = "*")]
        public string Sdt { get; set; }

        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "*")]
        public string Passwords { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "*")]
        [Compare("Passwords", ErrorMessage = "Mật khẩu không đúng.")]
        public string ConfirmPasswords { get; set; }

        public virtual ICollection<DbDonHang> DbDonHangs { get; set; } = new List<DbDonHang>();
        //public virtual ICollection<DbAddres> DbAddreses { get; set; } = new List<DbAddres>();

        //public virtual ICollection<DbTransaction> DbTransactions { get; set; } = new List<DbTransaction>();
    }
}
