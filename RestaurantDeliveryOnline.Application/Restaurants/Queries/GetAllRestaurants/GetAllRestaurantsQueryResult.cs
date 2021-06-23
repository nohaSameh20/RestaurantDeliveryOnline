using RestaurantDeliveryOnline.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Restaurants
{
    public class GetAllRestaurantsQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GetAllRestaurantsQueryResult()
        {

        }
        public GetAllRestaurantsQueryResult(Restaurant restaurant)
        {
            Id = restaurant.Id;
            Name = restaurant.Name;
            Description = restaurant.Description;
        }
    }
}
