using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;

namespace Yongbo.Model
{
    public class delete1
    {
        public int userdelete(int u12,IConfiguration con1) {
            int i = 0;

            using (SqlConnection con2 = new SqlConnection(con1.GetConnectionString("DBCS")))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE ID =  '" + u12 + "'",con2);
                {
                  con2.Open();
                  i = cmd.ExecuteNonQuery();
                }
                return i;
            }  
        }
    }
}
