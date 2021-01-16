using System.Collections.Generic;
using System.Reactive.Subjects;
using FlightTracker.Models;
using FlightTracker.Services.Interfaces;

namespace FlightTracker.Services
{
    public class SearchResults : ISearchResults
    {
        public Subject<List<Airport>> Results { get; set; } = new Subject<List<Airport>>();
    }
}