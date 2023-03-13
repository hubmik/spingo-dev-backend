using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AuthenticationController : Controller
    {
        public ActionResult IsAuthenticated(MerchantModel model)
        {

            return Redirect("/");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
