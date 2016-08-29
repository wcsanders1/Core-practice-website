using System.Collections.Generic;

namespace Core_practice_website.Models
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
    }
}