using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedStorage.Contexts
{
    public class BaseContext
    {
        public IDbConnection Connection { get; }

        public BaseContext(string connection)
        {
            Connection = new SqlConnection(connection);
        }
    }
}
