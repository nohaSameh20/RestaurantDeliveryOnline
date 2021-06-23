using RestaurantDeliveryOnline.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Cities
{
    public class LoadCitesQueryResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public LoadCitesQueryResult(City city)
        {
            Id = city.Id;
            Name = city.Name;
        }

    }
}
