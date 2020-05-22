using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using ZOOFET.services;
using ZOOFET.Models;
using System.Threading.Tasks;

namespace ZOOFET.services
{
    public class Animales_services
    {
  
            public static Api Api = new Api();
            private static readonly HttpClient client = CrearHttpClient();

            private static HttpClient CrearHttpClient()
            {
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                return httpClient;
            }

            public async Task<List<listar_animales>> GetAnimals()
            {
                try
                {
                    string url = Api.Url + "animales/listar_animales";
                    // aqui realizo la peticion
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<List<listar_animales>>(json);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                return default;
            }

        
    }
}