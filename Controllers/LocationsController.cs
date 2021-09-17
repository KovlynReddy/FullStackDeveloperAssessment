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

        #region Locations

        public async Task<List<Locations>> GetAllLocations()
        {

            using (var httpClient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpClient.GetAsync("https://api.foursquare.com/v2/venues/explore?client_id=000MLTLRGKEVBPAYHBVUPP0NPCPRAZ11E22WXRWCL4R341GO&client_secret=M3CYWBKDUZ23R4BWVMEM1K5NFDPEGY5GM1PYKG4TQLJQZS2S&v=20180323&limit=1&feilds=name&ll=-29.688079382295278, 31.00824366802357&query=Landmark"))
                {

                    string apiresponse = await response.Content.ReadAsStringAsync();
                    Locations = JsonConvert.DeserializeObject<List<Locations>>(apiresponse);

                }
            }

            return Locations;
        }

        public async Task<List<Locations>> GetLocations(string LocationClause)
        {

            using (var httpClient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpClient.GetAsync(@$"https://api.foursquare.com/v2/venues/explore?client_id=000MLTLRGKEVBPAYHBVUPP0NPCPRAZ11E22WXRWCL4R341GO&client_secret=M3CYWBKDUZ23R4BWVMEM1K5NFDPEGY5GM1PYKG4TQLJQZS2S&v=20180323&limit=1&feilds=name&ll=-29.688079382295278, 31.00824366802357&query={LocationClause}"))
                {

                    string apiresponse = await response.Content.ReadAsStringAsync();
                    Locations = JsonConvert.DeserializeObject<List<Locations>>(apiresponse);

                }
            }

            return Locations;
        }

        public async Task<Locations> GetLocation(string LocationClause)
        {

            Locations Location = new Locations();

            using (var httpClient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpClient.GetAsync(@$"https://api.foursquare.com/v2/venues/explore?client_id=000MLTLRGKEVBPAYHBVUPP0NPCPRAZ11E22WXRWCL4R341GO&client_secret=M3CYWBKDUZ23R4BWVMEM1K5NFDPEGY5GM1PYKG4TQLJQZS2S&v=20180323&limit=1&feilds=name&ll=-29.688079382295278, 31.00824366802357&query={LocationClause}"))
                {

                    string apiresponse = await response.Content.ReadAsStringAsync();
                    Location = JsonConvert.DeserializeObject<Locations>(apiresponse);

                }
            }

            return Location;
        } 
        #endregion
    }
}
