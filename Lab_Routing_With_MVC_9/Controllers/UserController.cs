using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Lab_Routing_With_MVC_9.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult settings(int? id)
        {
            string? controller = RouteData.Values["controller"]!.ToString();
            string? action = RouteData.Values["action"]!.ToString();
            //string? id = RouteData.Values["id"]!.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><ul>");
            sb.Append($"<li>Controller: {controller}</li>");
            sb.Append($"<li>Action    : {action}</li>");
            sb.Append($"<li>Id        : {id}</li>");
            sb.Append("</ul></html>");
            return Content(sb.ToString(), "text/html");
        }
    }
}
