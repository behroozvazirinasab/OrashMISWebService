using SharedStorage.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISServiceHub.Contexts
{
    public class OMISDBContext : BaseContext
    {
        public OMISDBContext(string connection) : base(connection)
            {
            }
    }
}
