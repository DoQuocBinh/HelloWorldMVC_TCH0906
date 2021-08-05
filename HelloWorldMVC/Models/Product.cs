using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(10,20,ErrorMessage ="between 10 and 20")]
        public decimal Price { get; set; }
        public bool IsOnSale { get; set; }

        [Required(ErrorMessage ="Must enter picture")]
        public string PictureUrl { get; set; }

    }
}
