using System.Data.SqlClient;

namespace Yongbo.Model
{
    public class Adduser
    {
        public int Addusers(users user1, IConfiguration conn4)
        {
            int i = 0;
            using (SqlConnection con1 = new SqlConnection(conn4.GetConnectionString("DBCS")))
            {

                SqlCommand c1 = new SqlCommand("INSERT  INTO Users (Fname,Lname,Email,Password1) VALUES ('" + user1.Fname + "','" + user1.Lname + "','" + user1.Email + "','" + user1.password + "')", con1);
                {
                    con1.Open();
                    i = c1.ExecuteNonQuery();
                    con1.Close();
                }
                return i;
               
            }
        }
    }
}
