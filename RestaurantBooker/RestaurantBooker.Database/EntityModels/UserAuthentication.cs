using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantBocker.Database.EntityModels
{
    public class UserAuthentication
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Role { get; set; }
    }
}
