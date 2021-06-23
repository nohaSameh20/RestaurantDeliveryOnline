using RestaurantDeliveryOnline.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Users
{
    public class UserCountQuery : IUserCountQuery
    {
        IDatabaseService databaseService;

        public UserCountQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public int Execute()
        {
            var res = databaseService.Users.Count();
            return res; 
        }
         
    }
}
