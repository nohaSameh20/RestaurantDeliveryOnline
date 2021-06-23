using RestaurantDeliveryOnline.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Restaurants
{
    public class RestaurantCountQuery : IRestaurantCountQuery
    {
        IDatabaseService databaseService;

        public RestaurantCountQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public int Execute()
        {
            var res = databaseService.Restaurants.Count();
            return res; 
        }
         
    }
}
