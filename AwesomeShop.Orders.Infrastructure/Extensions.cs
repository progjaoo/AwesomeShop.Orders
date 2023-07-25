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
            services.AddSingleton(
            {
                // var configuration = sp.GetService<IConfiguration>();
                // var options = new MongoDbOptions();

                // configuration.GetSection("Mongo").Bind(options);

                // return options;

                sp =>
                var configuration = sp.GetRequiredService<IConfiguration>();
                var options = new MongoDbOptions();

                var mongoConfigSection = configuration.GetSection("Mongo");
                options = mongoConfigSection.Get<MongoDbOptions>();

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