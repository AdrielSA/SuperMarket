using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int? CategoryId { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public double? Price { get; set; }


        public virtual Category Category { get; set; }
    }
}
