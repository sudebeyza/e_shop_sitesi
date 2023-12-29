using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required (ErrorMessage="bos Gecilemez")]
        [Display(Name ="Ad")]
        [StringLength(50,ErrorMessage ="max 50 karakter olmalidir")]


        public string Name { get; set; }

        [Required(ErrorMessage = "bos Gecilemez")]
        [Display(Name = "Aciklama")]
        [StringLength(50, ErrorMessage = "max 50 karakter olmalidir")]
        public string Description { get; set; }
        public virtual List <Product> Products{ get; set; }


    }
}
