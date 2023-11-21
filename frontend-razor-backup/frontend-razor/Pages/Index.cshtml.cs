using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace frontend_razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        [BindProperty]
        public string username { get; set; }

        [BindProperty]
        public string password { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (await EsUsuarioValido(username, password))
            {
                return RedirectToPage("/Privacy");
            }
            else
            {
                ViewData["ShowError"] = true; 
                return Page();
            }
        }

        private async Task<bool> EsUsuarioValido(string username, string password)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                var url = "https://localhost:7061/api/Usuario/VerificarUsuario";
                var data = new { Username = username, Password = password }; 

                using (var response = await client.PostAsJsonAsync(url, data))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        if (responseBody.ToLower() == "true")
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
