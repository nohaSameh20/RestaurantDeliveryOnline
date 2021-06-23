using RestaurantDeliveryOnline.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Cities
{
    public class LoadCitesQuery : ILoadCitesQuery
    {
        private readonly IDatabaseService databaseService;

        public LoadCitesQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public List<LoadCitesQueryResult> Execute()
        {
            List<LoadCitesQueryResult> res = databaseService.Cities.Where(obj => true)
                                                            .Select(obj => new LoadCitesQueryResult(obj))
                                                            .OrderBy(obj => obj.Name).ToList();

            return res;
        }
    }
}
