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
    [Table(nameof(Order))]
    public class Order : Entity<Guid>
    {
        

        [ForeignKey("User")]

        public Guid UserId { get; set; }

        public User User { get; set; }

        public List<OrderItem> orderItems { get; set; }
    }
}
