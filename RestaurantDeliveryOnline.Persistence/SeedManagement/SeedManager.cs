using RestaurantDeliveryOnline.Application.Interfaces;
using RestaurantDeliveryOnline.Presistence.SeedManagement;
using System.Collections.Generic;

namespace SaferCities.Presistence.SeedManagement
{
    public class SeedManager
    {
         
        IDatabaseService databaseService;
        List<ISeedCommand> seedObjs = new List<ISeedCommand>();

        private void InititSeedList()
        {
            
            seedObjs.Add(new InitSeedCommand(databaseService));
        }

        public SeedManager(  IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
            this.InititSeedList(); 
        }

        public void Seed()                                 
        {
            seedObjs.ForEach(obj => obj.Execute()); 
        }
    }
}