using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ria_musicstore.Models;

namespace ria_musicstore.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
			return "Hello from Store.Index()";
        }

		// Get: /Store/Browse?genre=Disco
		public string Browse(string Genre)
		{
			string message = HttpUtility.HtmlEncode($"Store.Browse, Genre  = {Genre}");
			return message;
		}
		// Get: /Store/Details/5
		public ActionResult Details(int id)
		{	
			var message = new Album { Title = $"Album {id}" };
			return View(message);
		}
    }
}
