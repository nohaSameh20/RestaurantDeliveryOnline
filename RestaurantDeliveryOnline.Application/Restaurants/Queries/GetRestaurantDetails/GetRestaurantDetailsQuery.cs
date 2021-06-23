using RestaurantDeliveryOnline.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Restaurants
{
    public class GetRestaurantDetailsQuery : IGetRestaurantDetailsQuery
    {
        IDatabaseService databaseService;
        public GetRestaurantDetailsQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public GetRestaurantDetailsQueryResult Execute(Guid id)
        {
            var restaurant = databaseService.Restaurants.Single(obj => obj.Id == id,inc=>inc.ProductList,inc=>inc.City);

            if (restaurant == null)
                throw new Exception("InvalidUserId");

            GetRestaurantDetailsQueryResult res = new GetRestaurantDetailsQueryResult(restaurant);
            res.ProductList = restaurant.ProductList;
            return res;
        }
    }
}
