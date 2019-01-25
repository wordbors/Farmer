using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmer.Services;
using Microsoft.AspNetCore.Mvc;

namespace Farmer.Web.Controllers
{
    public class NomenclaturesController : Controller
    {
        private readonly INomenclaturesService nomService;

        public NomenclaturesController(INomenclaturesService nomService)
        {
            this.nomService = nomService;
        }

        public IActionResult ShowVillage()
        {
            return View(nomService.GetVillages());
        }

    }
}