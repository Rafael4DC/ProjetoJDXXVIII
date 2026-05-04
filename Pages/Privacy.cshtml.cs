using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjetoJDXXVIIIModel;
using ProjetoJDXXVIIIServices;
namespace ProjetoJDXXVIII.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        internal List<Supplier> Ids = new List<Supplier>();

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Ids = BaseServices.GetSupplierIds();
        }
    }

}
