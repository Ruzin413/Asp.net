using System.Data;
using System.Data.SqlClient;

namespace Yongbo.Model
{
    public class Dal
    {
        public List<users> Getusers(IConfiguration Connection1){ 
            List<users> Listusers = new List<users>();
            using (SqlConnection con = new SqlConnection(Connection1.GetConnectionString("DBCS").ToString()))
            { 
                SqlDataAdapter d1 = new SqlDataAdapter("SELECT * FROM Users", con);
                DataTable dt = new DataTable();
                d1.Fill(dt);
                if (dt.Rows.Count > 0){ 
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        users u1 = new users(); 
                        u1.ID= Convert.ToInt32(dt.Rows[i]["ID"]);
                        u1.Fname = Convert.ToString(dt.Rows[i]["Fname"]);
                        u1.Lname = Convert.ToString(dt.Rows[i]["Lname"]);
                        u1.Email = Convert.ToString(dt.Rows[i]["Email"]);
                        u1.password = Convert.ToString(dt.Rows[i]["Password1"]);
                        u1.Date = Convert.ToString(dt.Rows[i]["Date1"]);
                        Listusers.Add(u1);
                    }
                }
            }

            return Listusers;
        }
    }
}
