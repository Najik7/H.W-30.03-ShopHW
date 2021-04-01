using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHW.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ModelName { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
