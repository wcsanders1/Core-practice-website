using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core_practice_website.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
        Trip GetTripByName(string tripName);

        void AddTrip(Trip trip);

        Task<bool> SaveChangesAsync();
    }
}