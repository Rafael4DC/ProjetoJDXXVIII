using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Primitives;
using ProjetoJDXXVIIIModel;
using ProjetoJDXXVIIIServices;
namespace ProjetoJDXXVIII.Pages
{
    public class SignupModel : PageModel
    {
        private readonly ILogger<SignupModel> _logger;

        public SignupModel(ILogger<SignupModel> logger)
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
            string firstname = this.Request.Form["firstname"];
            string lastname = this.Request.Form["lastname"];

            var res = BaseServices.SignUp(username, password,firstname,lastname);

            if (res.ans) {
                return RedirectToPage("/Login");
            }


            return RedirectToPage("/Index");
        }
    }

}
