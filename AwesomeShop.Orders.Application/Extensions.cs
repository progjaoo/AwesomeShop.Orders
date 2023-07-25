using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShop.Orders.Application.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace AwesomeShop.Orders.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR(typeof(AddOrder));

            return services;
        }
    }
}