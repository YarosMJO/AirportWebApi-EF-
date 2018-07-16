using Repositories.Seeder;

namespace AirportWebApi.DAL.Repositories
{
    public class BaseRepository
    {

        public Seeder seeder = null;

        public BaseRepository()
        {
            seeder = new Seeder();
        }
    }

}
