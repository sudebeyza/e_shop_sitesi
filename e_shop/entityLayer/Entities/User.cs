using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        public string SurName { get; set; }

        //[Required(ErrorMessage = "bos Gecilemez")]
        //[Display(Name = "E-Posta")]
        //[StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        //[EmailAddress(ErrorMessage ="E-mail formati seklinde giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Kullanici Adi")]
        [StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]

        public string Username { get; set; }

        //[Required(ErrorMessage = "bos Gecilemez")]
        //[Display(Name = "Sifre")]
        //[StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required(ErrorMessage = "bos Gecilemez")]
        //[Display(Name = "Sifre")]
        //[StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        //[DataType(DataType.Password)]
        //[Compare("Password",ErrorMessage ="sifreler uyusmuyor.")]
        public string RePassword { get; set; }

        [StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        public string Role { get; set; }
        
    }
}
