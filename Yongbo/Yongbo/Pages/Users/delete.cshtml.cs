using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yongbo.Model;

namespace Yongbo.Pages.Users
{
    public class deleteModel : PageModel
    {
        public users u1 = new users();
        public int IDD = 0;
        public String showerror = String.Empty;
        public readonly IConfiguration configuration;
        public deleteModel(IConfiguration configuration)
        {
            this .configuration = configuration;
        }
        public void OnGet()
        {
           IDD = Convert.ToInt32( Request.Query["id"]);
            try
            {
                delete1 d1 = new delete1();
                d1.userdelete(IDD, configuration);
            }
            catch (Exception ex) {
                showerror = $"Unable to fetch data: {ex.Message}";
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}
