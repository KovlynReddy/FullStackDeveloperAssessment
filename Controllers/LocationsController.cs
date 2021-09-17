using FullStackDeveloperAsessmentDDL.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FullStackDeveloperAssessment.Controllers
{
    public class LocationsController : Controller
    {
        public HttpClientHandler _ClientHandler { get; set; }
        public List<Locations> Locations { get; set; }
        public IActionResult Index()
        {
            return View();
        }

        public LocationsController()
        {
            _ClientHandler.ServerCertificateCustomValidationCallback = (sender,cert,chain,sslPolicyErrors) => { return (true); };
        }

        public async Task<List<Locations>> GetAllLocations()
        {

            using (var httpClient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpClient.GetAsync("api")  ) 
                {

                    string apiresponse = await response.Content.ReadAsStringAsync();
                    Locations = JsonConvert.DeserializeObject<List<Locations>>(apiresponse);
                
                }
            }

                return Locations;
        }

        public async Task<List<Locations>> GetLocations(string LocationClause) {

            using (var httpClient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpClient.GetAsync(@$"api/{LocationClause}"))
                {

                    string apiresponse = await response.Content.ReadAsStringAsync();
                    Locations = JsonConvert.DeserializeObject<List<Locations>>(apiresponse);

                }
            }

            return Locations;
        }
        
        public async Task<Locations> GetLocation(string LocationClause) {

            Locations Location = new Locations();

            using (var httpClient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpClient.GetAsync(@$"api/{LocationClause}"))
                {

                    string apiresponse = await response.Content.ReadAsStringAsync();
                    Location = JsonConvert.DeserializeObject<Locations>(apiresponse);

                }
            }

            return Location;
        }
    }
}
