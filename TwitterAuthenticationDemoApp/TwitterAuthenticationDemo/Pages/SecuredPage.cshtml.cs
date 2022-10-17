using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TwitterAuthenticationDemo.Pages
{
    [Authorize]
    public class SecuredPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
