using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using ProjetoJDXXVIIIModel;
using ProjetoJDXXVIIIServices;
namespace ProjetoJDXXVIII.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            string username = this.Request.Form["username"];
            string password = this.Request.Form["password"];

            User? user = BaseServices.Login(username, password);

            if (user == null) {
                return RedirectToPage("/Login");
            }

            Console.WriteLine("User: "+ user.FirstName +" "+user.LastName);

            HttpContext.Response.Cookies.Append("user",user.UserId);

            return RedirectToPage("/Index");
        }
    }

}
