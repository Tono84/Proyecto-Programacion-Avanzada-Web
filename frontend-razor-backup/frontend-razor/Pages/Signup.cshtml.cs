using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace frontend_razor.Pages
{
    public class SignupModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public SignupModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [BindProperty]
        public string nombreUsuario { get; set; }

        [BindProperty]
        public string contraseña { get; set; }

        [BindProperty]
        public string confirmPassword { get; set; }

        [BindProperty]
        public string nombre { get; set; }

        [BindProperty]
        public string apellido { get; set; }

        [BindProperty]
        public string correo { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (contraseña != confirmPassword)
            {
                ViewData["ShowPWError"] = true;
                return Page();
            }
            if (await agregarUsuario())
            {
                return RedirectToPage("Index");
            }
            else
            {
                ViewData["ShowError"] = true;
                return Page();
            }
        }

        private async Task<bool> agregarUsuario()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = "https://localhost:7061/api/Usuario";

                var data = new { nombreUsuario, contraseña, nombre, apellido, correo };

                using (var response = await client.PostAsJsonAsync(url, data))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        if (response.IsSuccessStatusCode)
                        {
                            return true;
                        }

                        return false;
                    }
                    else
                    {
                        _logger.LogError($"Error: {response.StatusCode}, {response.ReasonPhrase}");
                        return false;
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Error");
                return false;
            }
        }

    }
}
