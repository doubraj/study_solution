using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String ImgUri { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal Price { get; set; }
        public String Description { get; set; }
    }
}