using CoreNFC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheaterApp.Models;


namespace WheaterApp.ApiService
{
    public static class ApiService
    {
        public static async Task<Root> GetWeather(double latitude,double longitudo)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(String.Format(""));
            return JsonConvert.DeserializeObject<Root>(response);
        }

        public static async Task<Root> GetweatherByCiyt(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format(""));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }



}