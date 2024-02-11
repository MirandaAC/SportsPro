using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsPro.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a product code.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter a product name.")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        [Required(ErrorMessage = "Please enter a valid yearly price.")]
        public double YearlyPrice { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public string Slug => Name?.Replace(' ', '-').ToLower() + '-' + CreatedDateTime.ToString("yyyyMMddHHmmss");
    }
}
