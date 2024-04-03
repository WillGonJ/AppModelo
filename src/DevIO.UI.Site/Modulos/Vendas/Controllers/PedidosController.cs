

using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Vendas.Controllers
{
    public class PedidosController : Controller
    {
        [Area("Vendas")]
        public  IActionResult Index()
        {
            return View();
        }
    }

}