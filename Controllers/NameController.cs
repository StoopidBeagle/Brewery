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
    public class NameController : Controller
    {
        private static readonly List<Name> Names = new List<Name>()
        {
           new Name()
	   {
               Value = "Sean", 
               Gender = "M",
	       Meaning = "God is gracious" 
	   },
	   new Name()
	   {
               Value = "Mary", 
	       Gender = "F",
	       Meaning = "Beloved, bitter, or rebellious"
	   },
	   new Name()
	   {
	       Value = "Noah", 
	       Gender = "F",
	       Meaning = "Movement"
	   }
        };

        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Name> Get()
        {
            return Names;
        }

	[Route("/names")]
	public ActionResult NameListView() 
	{
	    return View(Names);
	}

	[Route("/names/{value}")]
	public ActionResult NameDetailView(string value)
	{
	    Console.WriteLine($"Looking for {value}");
            try 
            {
                var name = Names.First(o => o.Value.ToLower() == value.ToLower());
                return View(name);
	    }
	    catch
	    {
                return NotFound();
	    }
	}
    }
}
