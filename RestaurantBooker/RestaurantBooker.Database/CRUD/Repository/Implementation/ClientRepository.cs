using RestaurantBocker.Database.Context;
using RestaurantBocker.Database.EntityModels;

namespace ClassLibrary1.CRUD.Repository.Implementation
{
    public class ClientRepository : GenericRepository<Client>
    {
        public ClientRepository(DatabaseContext context):base(context)
        {

        }
    }
}
