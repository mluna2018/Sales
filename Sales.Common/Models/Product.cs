
namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public String Description { get; set; }

        public decimal price { get; set; }

        public bool Isavailable { get; set; }

        public DateTime PublishOn { get; set; }
    }
}
