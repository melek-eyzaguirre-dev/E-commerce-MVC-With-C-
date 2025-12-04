using Microsoft.AspNetCore.Mvc;
using ECommerce.Core.Models;

namespace ECommerce.Web.Controllers
{
    public class ProductController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken] // Protección contra CSRF
        public IActionResult Create(Product product)
        {
            try // Manejo de excepciones
            {
                if (ModelState.IsValid)
                {
                    // Lógica para guardar el producto
                    // ...
                    TempData["Success"] = "Producto creado exitosamente";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                // Logging del error (usar ILogger en producción)
                TempData["Error"] = "Error al crear el producto";
            }
            return View(product);
        }
    }
}