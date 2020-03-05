using RestaurantBocker.Database.Context;
using RestaurantBocker.Database.EntityModels;

namespace ClassLibrary1.CRUD.Repository.Implementation
{
    public class ReservationRepository : GenericRepository<Reservation>
    {
        public ReservationRepository(DatabaseContext context):base(context)
        {

        }
    }
}
