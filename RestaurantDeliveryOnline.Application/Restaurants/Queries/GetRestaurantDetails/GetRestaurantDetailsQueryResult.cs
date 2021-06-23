using RestaurantDeliveryOnline.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Restaurants
{
    public class GetRestaurantDetailsQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public ICollection<Product> ProductList { get; set; }
        public GetRestaurantDetailsQueryResult()
        {

        }
        public GetRestaurantDetailsQueryResult(Restaurant restaurant)
        {
            Id = restaurant.Id;
            Name = restaurant.Name;
            Description = restaurant.Description;
            Location = restaurant.City.Name;
        }
    }
}
