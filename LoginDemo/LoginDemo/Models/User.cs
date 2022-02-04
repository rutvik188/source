using System.ComponentModel.DataAnnotations;

namespace LoginDemo.Models
{
    public class User
    {
        [Key]
        public int Id  { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsEmailConfirmed { get; set; } 
        [Required]
        public String Password { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }
}
