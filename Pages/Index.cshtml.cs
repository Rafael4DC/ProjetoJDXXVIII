using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoJDXXVIIIModel;
using ProjetoJDXXVIIIServices;
using System.Linq;

namespace ProjetoJDXXVIII.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        internal User? user = new User();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string? userId = HttpContext.Request.Cookies["user"];
            if (userId != null)
            {
                user = BaseServices.GetUser(userId);
            }
        }
    }
}
