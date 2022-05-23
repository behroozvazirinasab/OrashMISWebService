using OMISWS_ServiceHub.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISWS_ServiceHub.Services
{
    public class PersonService
    {
        private readonly OMISWSDBContext dbContext;

        public PersonService(OMISWSDBContext _dbContext)
        {
            dbContext = _dbContext;
        }






    }
}
