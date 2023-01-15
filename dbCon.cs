using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eapartments
{
    internal class dbCon
    {
        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["EapartmentsConnectionString"].ConnectionString);
    }
}
