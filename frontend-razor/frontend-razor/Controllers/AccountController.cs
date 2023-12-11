using frontend.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace frontend.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Member"); 
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var (isAuthenticated, user) = await IsUserValid(model);

            if (isAuthenticated)
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.NombreUsuario),
            new Claim(ClaimTypes.NameIdentifier, user.idUsuario.ToString()),
            new Claim("MembresiaID", user.MembresiaID.ToString()),
        };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Member");
            }
            else
            {
                // Invalid login, show error
                ViewData["ShowError"] = true;
                return View(model);
            }
        }


        private async Task<(bool IsAuthenticated, Usuario User)> IsUserValid(LoginViewModel model)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = "https://localhost:7061/api/Usuario/VerificarUsuario";

                using (var response = await client.PostAsJsonAsync(url, model))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var user = await response.Content.ReadFromJsonAsync<Usuario>();

                        return (true, user);
                    }
                    else
                    {
                        return (false, null);
                    }
                }
            }
            catch (HttpRequestException)
            {
                return (false, null);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Usuario model)
        {
            if (ModelState.IsValid)
            {
                if (await AgregarUsuario(model))
                {
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Error al registrar el usuario.");
                    return View(model);
                }
            }

            return View(model);
        }

        private async Task<bool> AgregarUsuario(Usuario model)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = "https://localhost:7061/api/Usuario";

                var data = new
                {
                    nombreUsuario = model.NombreUsuario,
                    contraseña = model.Contraseña,
                    nombre = model.Nombre,
                    apellido = model.Apellido,
                    correo = model.Correo
                };

                using (var response = await client.PostAsJsonAsync(url, data))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        try
                        {
                            var jsonObject = JsonSerializer.Deserialize<Usuario>(responseBody);

                            return jsonObject.idUsuario > 0;
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
    }
}
