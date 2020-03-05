using RestaurantBocker.Database.Context;
using RestaurantBocker.Database.EntityModels;

namespace ClassLibrary1.CRUD.Repository.Implementation
{
    public class UserAuthenticationRepository:GenericRepository<UserAuthentication>
    {
        public UserAuthenticationRepository(DatabaseContext context):base(context)
        {

        }
    }
}
