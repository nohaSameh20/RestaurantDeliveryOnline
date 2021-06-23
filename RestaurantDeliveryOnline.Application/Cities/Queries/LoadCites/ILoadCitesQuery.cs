using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Cities
{
   public interface ILoadCitesQuery
    {
        List<LoadCitesQueryResult> Execute();
    }
}
