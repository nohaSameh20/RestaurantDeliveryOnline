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
    [Table(nameof(Product))]
    public class Product : Entity<Guid>
    {
       
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Photo { get; set; }

        [ForeignKey("Restaurant")]
        public Guid RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }



    }
}
