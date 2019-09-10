using Microsoft.AspNetCore.Mvc;
namespace Dropbox.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult info(){
            return View();
        }
    }
}