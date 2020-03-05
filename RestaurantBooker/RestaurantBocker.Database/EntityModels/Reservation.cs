using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RestaurantBocker.Database.EntityModels
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string PhoneContact { get; set; }
        public string Observation { get; set; }
        [Required]
        public int State { get; set; }

        [ForeignKeyAttribute("ClientId")]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        [ForeignKeyAttribute("RestaurantId")]
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
