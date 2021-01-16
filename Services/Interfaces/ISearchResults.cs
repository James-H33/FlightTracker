using System.Collections.Generic;
using System.Reactive.Subjects;
using FlightTracker.Models;

namespace FlightTracker.Services.Interfaces
{
    public interface ISearchResults
    {
        Subject<List<Airport>> Results { get; set; }
    }
}