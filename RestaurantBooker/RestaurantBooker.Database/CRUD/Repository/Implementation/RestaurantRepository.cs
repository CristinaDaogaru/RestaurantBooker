using RestaurantBocker.Database.Context;
using RestaurantBocker.Database.EntityModels;

namespace ClassLibrary1.CRUD.Repository.Implementation
{
    public class RestaurantRepository : GenericRepository<Restaurant>
    {
        public RestaurantRepository(DatabaseContext context) :base(context)
        { }
    }
}
