using Microsoft.AspNetCore.Mvc;

namespace PORTALNOTICIAS.Controllers
{
    public class NoticiasController : Controller
    {
        public IActionResult UltimasNoticias(){
            return View();
        }
        public IActionResult NoticiasPorCategoria(){
            return View();
        }        
    }
}