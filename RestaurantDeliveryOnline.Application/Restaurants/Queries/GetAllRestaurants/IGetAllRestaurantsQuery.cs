using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Restaurants
{
   public interface IGetAllRestaurantsQuery
    {
        List<GetAllRestaurantsQueryResult> Execute(RestaurantFilter filter);
    }
}
