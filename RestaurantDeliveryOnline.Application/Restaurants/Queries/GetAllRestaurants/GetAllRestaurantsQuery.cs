using RestaurantDeliveryOnline.Application.Interfaces;
using RestaurantDeliveryOnline.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Restaurants
{
    public class GetAllRestaurantsQuery : IGetAllRestaurantsQuery
    {
        IDatabaseService databaseService;
        public GetAllRestaurantsQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public List<GetAllRestaurantsQueryResult> Execute(RestaurantFilter filter)
        {
            var query = databaseService.Restaurants.Where(obj => true);

            // Adding NameLike Filter 
            if (!String.IsNullOrWhiteSpace(filter.Name))
                query = query.Where(p => p.Name.ToUpper().Contains(filter.Name.Trim().ToUpper()));

            // Adding NameLike Filter 
            if (filter.CityId !=Guid.Empty)
                query = query.Where(p => p.CityId==filter.CityId);

            List<GetAllRestaurantsQueryResult> result = query.ToList().Select(obj =>
            {
                var restaurants = new GetAllRestaurantsQueryResult(obj);
                return restaurants;
            }).ToList();

            return result;

        }
    }
}
