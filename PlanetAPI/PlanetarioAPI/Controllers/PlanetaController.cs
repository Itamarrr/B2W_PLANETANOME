using PlanetarioAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlanetarioAPI.Controllers
{
    public class PlanetaController : Controller
    {
        private readonly IServico _servico;
        public PlanetaController(IServico servico) 
        {
            _servico = servico;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Planeta(int id)
        {
            Planeta p = _servico.GetPlaneta(id);

            return View(p);
        }
    }
}