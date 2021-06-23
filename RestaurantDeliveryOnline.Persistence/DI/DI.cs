using Microsoft.Extensions.DependencyInjection;
using RestaurantDeliveryOnline.Application.Interfaces;
using RestaurantDeliveryOnline.Persistance.Core;
using SaferCities.Presistence.SeedManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Persistance
{
    public static class DI
    {
        public static void RegisterPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IDataBaseServiceOptions>(provider => new DataBaseServiceOptions() { ConnectionString = connectionString, Provider = services.BuildServiceProvider() });

            services.AddDbContext<DatabaseService>();
            services.AddScoped<IDatabaseService, DatabaseService>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<SeedManager, SeedManager>();


            SeedManager seedManager = services.BuildServiceProvider().GetService<SeedManager>();
            seedManager.Seed();
        }
    }
}
