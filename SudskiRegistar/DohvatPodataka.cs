using System;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Collections.Generic;
using SudskiRegistar.Classes;
using Newtonsoft.Json;

namespace SudskiRegistar.Data
{
    public static class DohvatPodataka
    {
        private static string subscriptionKey = "{subscriptionKey}"; //sudreg-podaci.pravosudje.hr
        private static string tipIdentifikatora = "oib";

        public static Subjekt DohvatiPodatke(string identifikator)
        {
            Subjekt subjekt = new Subjekt();

            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                var uri = $"https://sudreg-api.pravosudje.hr/javni/subjekt_detalji?tipIdentifikatora={tipIdentifikatora}&identifikator={identifikator}";
                var response = client.GetAsync(uri).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (response.Content.ReadAsStringAsync().Result != null)
                    {
                        subjekt = JsonConvert.DeserializeObject<Subjekt>(response.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            return subjekt;
        }
    }
}
