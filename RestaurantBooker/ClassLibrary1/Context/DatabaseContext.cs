using RestaurantBocker.Database.EntityModels;
using System;
using System.Data.Entity;

namespace RestaurantBocker.Database.Context
{
   public class DatabaseContext : DbContext
    {
        public DatabaseContext():base("DatabaseContext") { }

        public DbSet<UserAuthentication> UserAuthentications { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                 .HasMany<Reservation>(c => c.Reservations)
                 .WithRequired(r => r.Client)
                 .HasForeignKey<Guid>(r => r.ClientId)
                 .WillCascadeOnDelete(false); 

            modelBuilder.Entity<Restaurant>()
                .HasMany<Reservation>(rs => rs.Reservations)
                .WithRequired(r => r.Restaurant)
                .HasForeignKey<Guid>(r => r.RestaurantId)
                .WillCascadeOnDelete(false);

        }
    }
}
