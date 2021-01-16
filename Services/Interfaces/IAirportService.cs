using System.Collections.Generic;
using System.Threading.Tasks;
using FlightTracker.Models;

namespace FlightTracker.Services.Interfaces
{
    public interface IAirportService
    {
        Task<List<Airport>> GetAirports(string searchText);
        List<Flight> GetArrivals();
        List<Flight> GetDepartures();
    }
}
