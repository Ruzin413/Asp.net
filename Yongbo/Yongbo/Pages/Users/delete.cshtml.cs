using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yongbo.Model;

namespace Yongbo.Pages.Users
{
    public class deleteModel : PageModel
    {
        public users u1 = new users();
        public String showerror = String.Empty;
        public readonly IConfiguration configuration;
        public deleteModel(IConfiguration configuration)
        {
            this .configuration = configuration;
        }
        public void OnGet()
        {
            u1.ID = Convert.ToInt32( Request.Query["id"]);
            try
            {
                delete1 d1 = new delete1();
                d1.userdelete(u1, configuration);
            }
            catch (Exception ex) {
                showerror = $"Unable to fetch data: {ex.Message}";
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
