using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Yongbo.Model;

namespace Yongbo.Pages.Users
{
    public class EditModel : PageModel
    {
        public users u1 = new users();  
        public String showerror = String.Empty;
        public String showinfo = String.Empty;
        public readonly IConfiguration configuration;
        public EditModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void OnGet()
        {
            int  id = Convert.ToInt32(Request.Query["id"]);
            try
            {
                Edit e1 = new Edit();
              u1 =  e1.displayEditUser(id, configuration);
                if (u1 == null || string.IsNullOrEmpty(u1.Fname))
                {
                    showerror = "User not found!";
                }

            }
            catch (Exception ex) {
                showerror = $"Unable to fetch data: {ex.Message}";
                Console.WriteLine($"Error: {ex.Message}");

            }
           

        } 
        public void OnPost()
        {
            int id = Convert.ToInt32(Request.Form["HID"]);
            u1.Fname = Request.Form["Fname"];
            u1.Lname = Request.Form["Lname"];
            u1.Email = Request.Form["Email"];
            u1.password = Request.Form["password1"];
            try
            {
                Edit e1 = new Edit();
                e1.Edituser(id, configuration, u1);
            }
            catch (Exception ex) {
                showerror = $"Unable to fetch data: {ex.Message}";
                Console.WriteLine($"Error: {ex.Message}");
            }
            


        }
    }
}
