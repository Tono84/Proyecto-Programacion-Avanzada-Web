using frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Security.Claims;

namespace frontend.Controllers
{
    public class MembershipController : Controller
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public MembershipController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Confirmation() 
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var membresias = await GetMembresias();

                if (membresias != null)
                {

                    ViewBag.Membresias = membresias;
                }
                else
                {

                    ViewBag.ErrorMessage = "Error fetching membresias data.";
                }
            }
            catch (Exception ex)
            {

                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
            }

            return View();
        }


        private async Task<List<Membresia>> GetMembresias()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = $"https://localhost:7061/api/Membresias";

                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<List<Membresia>>();
                    }
                    else
                    {

                        return null;
                    }
                }
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        public ActionResult AcceptarMembresia(int MembresiaID)
        {

            var idUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.idUsuario = idUsuario;
            ViewBag.MembresiaID = MembresiaID;
            return View(MembresiaID);
        }

    }
}
