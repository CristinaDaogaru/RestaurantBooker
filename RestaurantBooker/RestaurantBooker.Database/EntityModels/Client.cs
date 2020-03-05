using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBocker.Database.EntityModels
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(13)]
        public string Phone { get; set; }
        public Guid UserAuthenticationId { get; set; }

        [ForeignKeyAttribute("UserAuthenticationId")]
        public virtual UserAuthentication UserAuthentication { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
