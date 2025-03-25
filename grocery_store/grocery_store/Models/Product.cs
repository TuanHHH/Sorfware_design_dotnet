using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace grocery_store.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "mediumtext")]
        public string? Description { get; set; }

        [Column("image_url")]
        [MaxLength(255)]
        public string? ImageUrl { get; set; }

        public double Price { get; set; }

        [Column("product_name")]
        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }

        public int? Quantity { get; set; }

        [MaxLength(20)]
        public string? Unit { get; set; }

        [Column("category_id")]
        public long CategoryId { get; set; }

        //[Column(TypeName = "datetime")]
        //public DateTime CreatedAt { get; set; }

        //[Required]
        //[MaxLength(255)]
        //public string CreatedBy { get; set; }

        //[Column(TypeName = "datetime")]
        //public DateTime? UpdatedAt { get; set; }

        //[MaxLength(255)]
        //public string UpdatedBy { get; set; }

        public double? Rating { get; set; }

        public int? Sold { get; set; }

        //// Navigation property
        //public virtual Category Category { get; set; }

        //public string category_id { get; set; }

        // Entity framework conventions to handle the creation and update timestamps
        //public Product()
        //{
        //    CreatedAt = DateTime.Now;
        //}

        //public void OnUpdate()
        //{
        //    UpdatedAt = DateTime.Now;
        //}
    }
}


