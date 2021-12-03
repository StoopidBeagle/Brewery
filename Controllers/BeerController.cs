using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using app.Models;

namespace app.Controllers
{
    [ApiController]
    [Route("/v1/names")]
    public class BeerController : Controller
    {
        private static readonly List<Beer> Beers = new List<Beer>()
        {
            new Beer()
	        {
                ID = 1,
                Brewer = "Yuengling", 
                Name = "Traditional Lager",
	            Type = "Lager",
                ABV = 4.5,
                Color = "#FFBF00",
                Calories = 140,
	        },   
	        new Beer()
	        {
                ID = 2,
                Brewer = "Coors", 
	            Name = "Banquet",
	            Type = "Lager",
                ABV = 5.0,
                Color = "#FFBF00",
                Calories = 149,
	        },
	        new Beer()
	        {
                ID = 3,
	            Brewer = "Coors", 
	            Name = "Light",
	            Type = "Lager"
	        }
        };

        private readonly ILogger<BeerController> _logger;

        public BeerController(ILogger<BeerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return Beers;
        }

        [Route("/beers")]
        public ActionResult BeerListView() 
        {
            return View(Beers);
        }

        [Route("/beers/{id}")]
        public ActionResult BeerDetailView(int id)
        {
            Console.WriteLine($"Looking for beer id={id}");
            try 
            {
                Beer model = Beers.First(beer => beer.ID == id);
                return View(model);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
