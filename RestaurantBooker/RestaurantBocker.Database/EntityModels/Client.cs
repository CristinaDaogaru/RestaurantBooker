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
        public string Name { get; set; }
        public string Phone { get; set; }

        [ForeignKeyAttribute("UserAuthenticationId")]
        public Guid UserAuthenticationId { get; set; }
        public virtual UserAuthentication UserAuthentication { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
