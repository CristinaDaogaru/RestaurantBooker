using ClassLibrary1.CRUD.Repository.Implementation;
using RestaurantBocker.Database.Context;
using System;

namespace ClassLibrary1.CRUD
{
    public class UnitOfWork : IDisposable
    {
        private DatabaseContext databaseContext = new DatabaseContext();

        private UserAuthenticationRepository userAuthenticationRepository;
        private ClientRepository clientRepository;
        private RestaurantRepository restaurantRepository;
        private ReservationRepository reservationRepository;

        private bool disposed = false;

        public UserAuthenticationRepository UserAuthenticationRepository
        {
            get
            {
                if (this.userAuthenticationRepository == null)
                {
                    this.userAuthenticationRepository = new UserAuthenticationRepository(databaseContext);
                }
                return userAuthenticationRepository;
            }
        }

        public ClientRepository ClientRepository
        {
            get
            {
                if (this.clientRepository == null)
                {
                    this.clientRepository = new ClientRepository(databaseContext);
                }
                return clientRepository;
            }
        }

        public RestaurantRepository RestaurantRepository
        {
            get
            {
                if (this.restaurantRepository == null)
                {
                    this.restaurantRepository = new RestaurantRepository(databaseContext);
                }
                return restaurantRepository;
            }
        }

        public ReservationRepository ReservationRepository
        {
            get
            {
                if(this.reservationRepository==null)
                {
                    this.reservationRepository = new ReservationRepository(databaseContext);
                }
                return reservationRepository;
            }
        }

        public void Save()
        {
            databaseContext.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    databaseContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
