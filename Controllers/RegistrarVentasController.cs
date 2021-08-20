using Microsoft.AspNetCore.Mvc;
using FormularioLabTarea.Models;

namespace FormularioLabTarea.Controllers
{
    public class RegistrarVentasController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Calcular(RegistrarVentas objRegistrarVentas)
        {
           double resultadoTotal=0;
           double subtotal=0;

           subtotal = objRegistrarVentas.Precio * objRegistrarVentas.Cantidad;

           resultadoTotal = subtotal* 1.18;

           ViewData["Message"] = "El precio total del producto incluido IGV es " + resultadoTotal;
           ViewData["Message1"] = "El subtotal del producto es " + subtotal;


           return View("Index");
        }
    }
}