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
    [Route("/api/beer-colors")]
    public class BeerColorController : Controller
    {
        private readonly ILogger<BeerColorController> _logger;

        public BeerColorController(ILogger<BeerColorController> logger)
        {
            _logger = logger;
        }

        [Route("/beer-colors")]
        public ActionResult BeerColorListView() 
        {
            return View(BeerColor.Colors);
        }
    }
}