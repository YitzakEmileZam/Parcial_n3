using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RemesasApp.Models;
using RemesasApp.Data;

namespace RemesasApp.Controllers
{
    //[Route("[controller]")]
    public class RemesasController : Controller
    {
        //private readonly ILogger<RemesasController> _logger;

        /*public RemesasController(ILogger<RemesasController> logger)
        {
            _logger = logger;
        }*/

         private readonly ApplicationDbContext _context;

        public RemesasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


 [HttpPost]
        public async Task<IActionResult> RegistrarRemesa(Remesa remesa)
        {
            if (ModelState.IsValid)
            {
                
                remesa.MontoFinal = remesa.MontoEnviado * remesa.TasaCambio;

               
                remesa.EstadoTransaccion = "Pendiente";

                
                _context.Add(remesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(remesa);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}