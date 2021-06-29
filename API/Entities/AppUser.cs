using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Users", Schema = "Security")]
    public class AppUser
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}