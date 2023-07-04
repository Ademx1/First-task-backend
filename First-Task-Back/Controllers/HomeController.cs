using Microsoft.AspNetCore.Mvc;

namespace backtask
{
	public class HomeController:Controller
	{
		public ContentResult Index()
		{
			return Content("Home page!");
		} 

		public ViewResult Contact()
		{
			return View();
		}

		public ContentResult About()
       {
			return Content("About page!"); 
       }
	}
}

