using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Yongbo.Model
{
    public class Edit
    {
        public users  displayEditUser(int id,IConfiguration con1)
        {
            users u1 = new users();
            int i = 0;
            using (SqlConnection conn2 = new SqlConnection(con1.GetConnectionString("DBCS"))){
                SqlDataAdapter s1 = new SqlDataAdapter("SELECT * FROM Users WHERE ID ='"+id+"'", conn2);
                DataTable dt1 = new DataTable();
                s1.Fill(dt1);
                if(dt1.Rows.Count > 0){
                    u1.Fname = Convert.ToString(dt1.Rows[0]["Fname"]);
                    u1.Lname = Convert.ToString(dt1.Rows[0]["Lname"]);
                    u1.Email = Convert.ToString(dt1.Rows[0]["Email"]);
                    u1.password = Convert.ToString(dt1.Rows[0]["password1"]);

                }
                return u1;
            }
           
        }
        public int Edituser(int id , IConfiguration conn1, users u1)
        {
             int i = 0;   
            using (SqlConnection conn2 = new SqlConnection(conn1.GetConnectionString("DBCS")))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Users SET Fname = '" + u1.Fname + "', Lname = '" + u1.Lname + "', Email = '" + u1.Email + "', Password1 = '" + u1.password + "' WHERE ID = '" + id + "'", conn2);
                {
                    conn2.Open();
                    i = cmd.ExecuteNonQuery();
                    conn2.Close();
                }
              return i;
            }
            
        }
    }  
}
