using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebAppAbra.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WebAppAbra.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public UserController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> GetRandomUser()
        {
            string apiUrl = "https://randomuser.me/api/";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                return Content(responseData, "application/json");
            }
            else
            {
                // Handle API error response
                string errorResponse = @"{ ""error"": ""Uh oh, something has gone wrong. Please tweet us @randomapi about the issue. Thank you."" }";
                return Content(errorResponse, "application/json");
            }
        }
        [HttpGet("gender/{gender}")]
        public async Task<IActionResult> GetUsersData(string gender)
        {
            if (gender != "male" && gender != "female")
            {
                return BadRequest("Invalid value. please enter 'male' or 'female'.");
            }

            string apiUrl = $"https://randomuser.me/api/?gender={gender}&results=10";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                return Content(responseData, "application/json");
            }
            else
            {
               
                string errorResponse = @"{ ""error"": ""An error occurred."" }";
                return Content(errorResponse, "application/json");
            }
        }
      
        [HttpGet("popular-country")]
        public async Task<IActionResult> GetPopularCountry()
        {
            string apiUrl = "https://randomuser.me/api/?results=5000";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var data = JObject.Parse(responseData);
                var results = data["results"];

                // Extract nationality data and count occurrences
                var nationalityCounts = new Dictionary<string, int>();
                foreach (var result in results)
                {
                    string nationality = result["nat"].ToString();
                    if (nationalityCounts.ContainsKey(nationality))
                    {
                        nationalityCounts[nationality]++;
                    }
                    else
                    {
                        nationalityCounts[nationality] = 1;
                    }
                }

                string mostPopularCountry = nationalityCounts.OrderByDescending(kv => kv.Value).First().Key;

                return Ok(new { MostPopularCountry = mostPopularCountry });
            }
            else
            {
                // handle API error response
                string errorResponse = @"{ ""error"": ""Uh oh, something has gone wrong. Please tweet us @randomapi about the issue. Thank you."" }";
                return Content(errorResponse, "application/json");
            }
        }
    }
}



        


