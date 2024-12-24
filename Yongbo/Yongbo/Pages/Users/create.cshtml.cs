using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yongbo.Model;

namespace Yongbo.Pages.Users
{
    public class createModel : PageModel
    {
        public users user= new users();
        public String showerror = String.Empty;
        public String showinfo = String.Empty;
        public readonly IConfiguration configuration;    
        public createModel(IConfiguration c1)
        {
            configuration = c1;
            
        }
        public void OnGet()
        {
        }
        public void OnPost() {
            user.Fname = Request.Form["fname"];
            user.Lname = Request.Form["lname"];
            user.Email = Request.Form["email"];
            user.password = Request.Form["password"];
            if (user.Fname.Length < 0 || user.Fname.Length == 0)
            {
                showerror = "Fill the given";
                return;
            }
            try{
                Adduser ad1 = new Adduser();
                ad1.Addusers(user, configuration);

            }
            catch
            {
                showerror = "data not sent";
            }
            showinfo = "data inserted";
            Response.Redirect("/Users/Index");
        }

    }
}
