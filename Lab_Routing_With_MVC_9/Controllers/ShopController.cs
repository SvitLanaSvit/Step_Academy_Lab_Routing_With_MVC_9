using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.Text;

namespace Lab_Routing_With_MVC_9.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buy()
        {
            string? controller = RouteData.Values["controller"]!.ToString();
            string? action = RouteData.Values["action"]!.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><ul>");
            sb.Append($"<li>Controller: {controller}</li>");
            sb.Append($"<li>Action: {action}</li>");
            sb.Append("</ul></html>");
            return Content(sb.ToString(), "text/html");
        }
    }
}
