using RestaurantDeliveryOnline.Application.Interfaces;
using RestaurantDeliveryOnline.Domain;
using System;
using System.Collections.Generic;

using System.Linq;

namespace RestaurantDeliveryOnline.Presistence.SeedManagement
{
    public class InitSeedCommand : BaseSeed
    {

        public InitSeedCommand(IDatabaseService databaseService)
            : base(databaseService)
        {
        }

        public override void Execute()
        {
            ////Cities
            ///
            SeedCities();
        }
        private void SeedCities()
        {
            if (!databaseService.Cities.Any())
            {
                List<City> cities = DATA.EGYPTCITIES.Select(obj => new City()
                {
                    Name = obj.Key,
                    Id=Guid.NewGuid(),
                    CreatedAt=DateTime.Now,
                }).ToList();
                databaseService.Cities.AddRange(cities);
                databaseService.Cities.SaveChanges();
               
            }
        }

        
    }

}
