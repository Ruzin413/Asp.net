using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yongbo.Model;

namespace Yongbo.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration conn1;
        public List<users> Listusers1 = new List<users>();
        public IndexModel(IConfiguration conn2)
        {
            conn1 = conn2;
        }

        public void OnGet()
        {
            Dal dal = new Dal();
            Listusers1 = dal.Getusers(conn1);

        }
    }
}
