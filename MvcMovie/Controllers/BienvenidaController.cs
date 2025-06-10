using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class BienvenidaController : Controller
    {
        public IActionResult Index()
        {
            string? nombreUsuario = HttpContext.Session.GetString("User");

            if (string.IsNullOrEmpty(nombreUsuario))
            {
                return RedirectToAction("Login", "Login");
            }

            ViewBag.Mensaje = $"¡Bienvenid@, {nombreUsuario}! Iniciaste sesión correctamente.";
            return View();
        }


    }
}

