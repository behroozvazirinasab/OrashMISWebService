﻿using Microsoft.Extensions.DependencyInjection;
using OMISWS_ServiceHub.Contexts;
using OMISWS_ServiceHub.Service;

namespace OMISServiceHub
{
    public static class ServiceHub
    {
        public static void AddServiceHubContainer(this IServiceCollection services, string _connection)
        {
            services.AddScoped<OMISWSDBContext>(dbc => new OMISWSDBContext(_connection));


            services.AddScoped<IRecivePaymentService, RecivePaymentService>();

        }
    }
}
