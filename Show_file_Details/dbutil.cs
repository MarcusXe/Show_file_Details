using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show_file_Details
{

    public static class dbutil
    {
        static string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wdcsz\source\repos\Show_file_Details\Show_file_Details\filetypeinfo.mdf;Integrated Security=True";
        static SqlConnection con = new System.Data.SqlClient.SqlConnection(constr);
        //static SqlCommand sqlcmd = new SqlCommand(sql, con);
        public static void initConn()
        {
            try {
                con.Open();
            } catch(Exception e){
                myerrors.showErrors(e);
            }                     
        }

    }
}
