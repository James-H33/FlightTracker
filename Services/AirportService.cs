using System.Threading.Tasks;
using System.Collections.Generic;
using FlightTracker.Models;
using AutoMapper;
using FlightTracker.Services.Interfaces;
using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace FlightTracker.Services
{
    public class AirportService : IAirportService
    {
        private readonly IMapper _mapper;
        private readonly HttpClient _http;
        private readonly string _baseUrl = "https://localhost:6001";

        public AirportService(IMapper mapper, HttpClient http)
        {
            _mapper = mapper;
            _http = http;
        }

        public async Task<List<Airport>> GetAirports(string searchText)
        {
            try {
                var response = await _http.GetAsync($"{_baseUrl}/airport/search?term={searchText}");
                var result = await response.Content.ReadAsStringAsync();
                var results = JsonConvert.DeserializeObject<List<Airport>>(result);

                return results;
            } catch (Exception err) {
                Console.WriteLine("[Error]: ", err);
                return new List<Airport>();
            }
        }

        public List<Flight> GetArrivals()
        {
            throw new NotImplementedException();
        }

        public List<Flight> GetDepartures()
        {
            throw new NotImplementedException();
        }
    }
}