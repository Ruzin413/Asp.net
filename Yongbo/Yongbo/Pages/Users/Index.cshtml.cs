using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yongbo.Model;

namespace Yongbo.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration connection1;
        public List<users> Listusers = new List<users>(); 
        public IndexModel(IConfiguration connection1)
        {
            this.connection1 = connection1;
        }

        public void OnGet()
        {
            Dal dal = new Dal();
            Listusers = dal.Getusers(connection1);

        }
    }
}
