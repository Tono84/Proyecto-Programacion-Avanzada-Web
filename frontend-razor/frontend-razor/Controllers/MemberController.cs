using frontend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;

namespace frontend.Controllers
{
    [Authorize]
    public class MemberController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MemberController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            var username = User.FindFirstValue(ClaimTypes.Name);

            ViewBag.Username = username;

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Rutinas()
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var ejercicios = await GetEjerciciosXUsuario(userId);

                if (ejercicios != null)
                {

                    ViewBag.Ejercicios = ejercicios;
                }
                else
                {

                    ViewBag.ErrorMessage = "Error fetching EjerciciosXUsuario data.";
                }
            }
            catch (Exception ex)
            {

                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
            }

            return View();
        }


        private async Task<List<EjercicioXUsuario>> GetEjerciciosXUsuario(string userId)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = $"https://localhost:7061/api/EjerciciosXUsuario/views/{userId}";

                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<List<EjercicioXUsuario>>();
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



        [HttpGet]
        public IActionResult CrearRutina()
        {
            var idUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.idUsuario = idUsuario;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CrearRutina(Rutina model)
        {
            if (ModelState.IsValid)
            {
                if (await AgregarRutina(model))
                {
                    return RedirectToAction("Rutinas", "Member");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error al registrar el rutina.");
                    return View(model);
                }
            }

            return View(model);
        }

        private async Task<bool> AgregarRutina(Rutina model)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = "https://localhost:7061/api/EjerciciosXUsuario";

                var data = new
                {
                    idUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier),
                idEjercicio = model.idEjercicio,
                    idRutina = model.idRutina,
                    cantidad = model.cantidad,
                };

                using (var response = await client.PostAsJsonAsync(url, data))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        try
                        {
                            var jsonObject = JsonSerializer.Deserialize<Rutina>(responseBody);

                            return jsonObject.idEjericioU > 0;
                        }
                        catch (JsonException)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Alimentos()
        {
            try
            {

                var alimentos = await GetAlimentos();

                if (alimentos != null)
                {

                    ViewBag.Alimentos = alimentos;
                }
                else
                {

                    ViewBag.ErrorMessage = "Error fetching Alimentos data.";
                }
            }
            catch (Exception ex)
            {

                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
            }

            return View();
        }

        private async Task<List<Alimento>> GetAlimentos()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = $"https://localhost:7061/api/Alimentos";

                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<List<Alimento>>();
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

        [HttpGet]
        public IActionResult AgregarAlimento()
        {
            return View();
        }

        public ActionResult EditarAlimento(int alimentoID)
        {
            ViewBag.alimentoID = alimentoID;
            return View(alimentoID);
        }

        [HttpGet]
        public async Task<IActionResult> Historial()
        {
            try
            {

                var historial = await GetHistorial();

                if (historial != null)
                {

                    ViewBag.Historial = historial;
                }
                else
                {

                    ViewBag.ErrorMessage = "Error fetching historial data.";
                }
            }
            catch (Exception ex)
            {

                ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
            }

            return View();
        }


        private async Task<List<Historial>> GetHistorial()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = $"https://localhost:7061/api/Inbody";

                using (var response = await client.GetAsync(url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadFromJsonAsync<List<Historial>>();
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

    }
}

