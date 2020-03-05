using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBocker.Database.EntityModels
{
    public class Reservation
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(13)]
        public string PhoneContact { get; set; }
        [MaxLength(500)]
        public string Observation { get; set; }
        [Required]
        public int State { get; set; }
        public Guid ClientId { get; set; }

        [ForeignKeyAttribute("ClientId")]
        public Client Client { get; set; }
        public Guid RestaurantId { get; set; }

        [ForeignKeyAttribute("RestaurantId")]
        public Restaurant Restaurant { get; set; }
    }
}
