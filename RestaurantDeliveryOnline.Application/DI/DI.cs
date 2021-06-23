using Microsoft.Extensions.DependencyInjection;
using RestaurantDeliveryOnline.Application.Cities;
using RestaurantDeliveryOnline.Application.Restaurants;
using RestaurantDeliveryOnline.Application.Users;

namespace RestaurantDeliveryOnline.Application
{
    public static class DI
    {
        public static void RegisterApplication(this IServiceCollection services)
        {
            //============Cities
            services.AddScoped<ILoadCitesQuery, LoadCitesQuery>();

            //===============Restaurants
            services.AddScoped<IGetAllRestaurantsQuery, GetAllRestaurantsQuery>();
            services.AddScoped<IGetRestaurantDetailsQuery, GetRestaurantDetailsQuery>();
            services.AddScoped<IRestaurantCountQuery, RestaurantCountQuery>();


            
            //========User
            services.AddScoped<IAddUserCommand, AddUserCommand>();
            services.AddScoped<IUserCountQuery, UserCountQuery>();





        }
    }
}
