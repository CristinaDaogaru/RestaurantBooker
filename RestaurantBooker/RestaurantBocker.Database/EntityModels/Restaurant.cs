using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestaurantBocker.Database.EntityModels
{
    public class Restaurant
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public int CuisineType { get; set; }

        [ForeignKeyAttribute("UserAuthenticationId")]
        public Guid UserAuthenticationId { get; set; }
        public virtual UserAuthentication UserAuthentication { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
