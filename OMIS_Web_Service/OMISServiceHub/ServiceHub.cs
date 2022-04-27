using Microsoft.Extensions.DependencyInjection;
using OMISServiceHub.Contexts;
using OMISServiceHub.IServices;
using OMISServiceHub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMISServiceHub
{
    public static class ServiceHub
    {
        public static void AddServiceHubContainer(this IServiceCollection services, string _connection)
        {
            services.AddScoped<OMISDBContext>(dbc => new OMISDBContext(_connection));

            services.AddScoped<IGoodService, GoodService>();

        }
    }
}
