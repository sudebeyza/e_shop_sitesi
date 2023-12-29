using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Aciklama")]
        [StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        public string Description { get; set; }

        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "fiyat")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Stok")]
        
        public int Stock { get; set; }
        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Populer")]
       
        public bool Popular { get; set; }
        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Onay")]
      
        public bool IsApproved { get; set; }
        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Resim")]
        public string Image { get; set; }


        
        [Display(Name = "Adet")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<Cart> Cart{ get; set; }
        public virtual List<Sales> Sales { get; set; }
    }
}
