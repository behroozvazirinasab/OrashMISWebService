using System.Data;
using System.Data.SqlClient;

namespace OMISWS_ServiceHub.Contexts
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
