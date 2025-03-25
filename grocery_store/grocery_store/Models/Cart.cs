using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace grocery_store.Models
{
    [PrimaryKey(nameof(ProductId), nameof(UserId))]
    public class Cart
    {
        [Key]
        [Column("product_id")]
        public long ProductId { get; set; }

        [Key]
        [Column("user_id")]
        public long UserId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("timestamp", TypeName = "TIMESTAMP(6)")]
        public DateTime Timestamp { get; set; }

        //[ForeignKey("UserId")]
        //public User User { get; set; }

        //[ForeignKey("ProductId")]
        //public Product Product { get; set; }
    }
}

