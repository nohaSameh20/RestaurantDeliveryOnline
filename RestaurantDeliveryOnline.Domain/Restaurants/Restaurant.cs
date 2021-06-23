using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDeliveryOnline.Domain
{
    [Table(nameof(Restaurant))]
    public class Restaurant : Entity<Guid>
    {
        
        public string Name { get; set; }
        public string Description { get; set; }

        [ForeignKey("City")]
        public Guid CityId { get; set; }
        public City City { get; set; }

        public ICollection<Product> ProductList { get; set; }
    }
}
