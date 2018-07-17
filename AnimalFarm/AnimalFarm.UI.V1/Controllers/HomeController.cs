using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalFarm.UI.V1.Models;
using AnimalFarm.Domain;

namespace AnimalFarm.UI.V1.Controllers
{
    public class HomeController : Controller
    {
		private readonly IFarm farm;

		public HomeController(IFarm farm)
		{
			this.farm = farm;
		}

        public IActionResult Index()
        {
			if (farm.IsOpen)
			{
				var viewModel = new HomeViewModel()
				{
					Elephants = farm.GetAllElephants().Select(e => new ElephantViewModel(e)),
					Parrots = farm.GetAllParrots().Select(p => new ParrotViewModel(p))
				};

				return View(viewModel);
			}
			else
				return RedirectToAction("FarmIsClosed");
        }

		public IActionResult FarmIsClosed()
		{
			return View();
		}
    }
}
