using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDeliveryOnline.Domain
{
    public class City: Entity<Guid>
    {
        public string Name { get; set; }
    }
}
