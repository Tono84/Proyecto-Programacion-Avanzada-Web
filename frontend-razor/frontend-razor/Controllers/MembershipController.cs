
using frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace frontend.Controllers
{
    public class MembershipController : Controller
    {
        private readonly MenteCuerpoDbContext _dbContext;

        public MembershipController(MenteCuerpoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            // Obtener tipos de membresía desde la base de datos
            var tiposMembresia = _dbContext.TipoMembresias.ToList();

            // Pasar los datos a la vista
            return View(tiposMembresia);
        }

        public IActionResult Confirmation(int planId)
        {
            // Obtener el tipo de membresía seleccionado desde la base de datos
            var planSeleccionado = _dbContext.TipoMembresias.FirstOrDefault(p => p.IdTipoMembresia == planId);

            // Guardar el objeto en TempData
            TempData["PlanSeleccionado"] = planSeleccionado;

            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }


    }
}
