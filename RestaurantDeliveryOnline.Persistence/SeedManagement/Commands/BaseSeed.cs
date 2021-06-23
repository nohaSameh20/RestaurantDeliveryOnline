using RestaurantDeliveryOnline.Application.Interfaces;
using RestaurantDeliveryOnline.Presistence.Data;
 

namespace RestaurantDeliveryOnline.Presistence.SeedManagement
{
    public abstract class BaseSeed : ISeedCommand
    {
        protected IDatabaseService databaseService;
        protected ConstData DATA; 

        public BaseSeed(IDatabaseService databaseService )
        {
            this.databaseService = databaseService;
            DATA = new ConstData(); 
        }

        public abstract void Execute(); 

       
    }
}
