using AwesomeShop.Orders.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace AwesomeShop.Orders.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            services.AddSingleton(sp =>
            {
                var configuration = sp.GetRequiredService<IConfiguration>();
                var options = new MongoDbOptions();

                configuration.GetSection("Mongo").GetConnectionString("ConnectionString");

                return options;
            });

            services.AddSingleton<IMongoClient>(sp =>
            {
                var options = sp.GetService<MongoDbOptions>();
                return new MongoClient(options.ConnectionString);

            });
            return services;
        }
    }
}