using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using GetAPISunset.Services;
using GetAPISunset.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace GetAPISunset
{
    class Program
    {
        static async Task Main(string[] args)
        {
            double latitude = 60.67452;
            double longitude = 17.14174;
            var _cityClient = new CityNameClient();
            var resultFromCity = await _cityClient.GetCityAsync(latitude, longitude);
            Console.WriteLine(resultFromCity.city.ToString());
        }
    }
}