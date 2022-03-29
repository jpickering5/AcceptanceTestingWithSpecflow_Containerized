using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product.Api.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; init; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal RRP { get; set; }

        public string CurrencyIsoCode { get; set; }

        public ProductCategory Category { get; set; }

        // public ICollection<Rating> Ratings { get; set; }
        //
        // public ICollection<Price> Prices { get; set;}
        //
        // public ICollection<ProductVariant> ProductVariants { get; set; }
        //
        // public ICollection<ProductPhoto> ProductPhotos { get; set; }
    }
}
