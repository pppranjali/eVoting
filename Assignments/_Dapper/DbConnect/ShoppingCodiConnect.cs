using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _Dapper.Constants;
using Microsoft.Data.SqlClient;

namespace _Dapper.DbConnect
{
    public class ShoppingCodiConnect
    {
        internal class EShopingCodiContext
        {
            private readonly string connStr;
            public EShopingCodiContext()
            {
                connStr = StaticConstants.ConnectionString;
            }
            // Retun an Instance of SqlCOnnection Class
            public IDbConnection CreateConnection()
                => new SqlConnection(connStr);
        }
    }
}
