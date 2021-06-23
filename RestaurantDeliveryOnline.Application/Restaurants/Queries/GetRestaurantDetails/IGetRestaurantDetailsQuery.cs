using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Restaurants
{
    public interface IGetRestaurantDetailsQuery
    {
        GetRestaurantDetailsQueryResult Execute(Guid id);
    }
}
