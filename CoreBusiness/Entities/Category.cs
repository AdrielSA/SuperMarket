using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Name { get; set; }

        public string Description { get; set; }

        
        public virtual List<Product> Products { get; set; }
    }
}
