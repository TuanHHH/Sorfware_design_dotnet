using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace grocery_store.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment for primary key
        public long Id { get; set; }

        
        [MaxLength(255)]
        public string? Address { get; set; }

        [Column("avatar_url")]
        [MaxLength(255)]
        public string AvatarUrl { get; set; }

        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string? Password { get; set; }

        [MaxLength(255)]
        public string? Phone { get; set; }

        public int Status { get; set; } // Assuming Status is an integer value (e.g., 0 = inactive, 1 = active)

        [Column("role_id")]
        public long? RoleId { get; set; } // Foreign key to Role table

        //[Column(TypeName = "mediumtext")] // Using mediumtext for storing the refresh_token
        //public string RefreshToken { get; set; }

        [MaxLength(255)]
        public string? Provider { get; set; }

        [Column("provider_id")]
        [MaxLength(255)]
        public string? ProviderId { get; set; }

        // Navigation property for Role (assuming you have a Role entity)
        //public virtual Role Role { get; set; }
    }
}
