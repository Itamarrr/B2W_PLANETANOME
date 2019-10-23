using Newtonsoft.Json;
using PlanetarioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PlanetarioAPI
{
    public class Servico : IServico
    {
        public WebClient client;

        private readonly string urlBase = "https://swapi.co/api";
        public Servico()
        {
            client = new WebClient();
            client.Headers["Content-type"] = "text/xml;charset=utf-8";
            client.Encoding = System.Text.Encoding.UTF8;

        }

        public Planeta GetPlaneta(int id)
        {
            var urlContent = client.DownloadString(urlBase + "/planets/"+id);

            var resultadoBicho = JsonConvert.DeserializeObject<Planeta>(urlContent);

            return resultadoBicho;

        }
    }
}