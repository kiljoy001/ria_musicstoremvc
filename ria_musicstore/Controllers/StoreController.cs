using System.Collections.Generic;
using System.Web.Mvc;
using ria_musicstore.Models;

namespace ria_musicstore.Controllers
{
	public class StoreController : Controller
	{
		public ActionResult Index()
		{
			//list of genre items
			var genres = new List<Genre>
			{
				new Genre { Name = "Disco" },
				new Genre { Name = "Drum and Bass"},
				new Genre { Name = "Dubstep"}
			};
			return View(genres);
		}

		// Get: /Store/Browse?genre=Disco
		public ActionResult Browse(string genre)
		{
			var genreModel = new Genre { Name = genre };
			return View(genreModel);
		}
		// Get: /Store/Details/5
		public ActionResult Details(int id)
		{
			var message = new Album { Title = $"Album {id}" };
			return View(message);
		}
	}
}
