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
    [Table(nameof(OrderItem))]
    public class OrderItem : Entity<Guid>
    {
        

        [ForeignKey("Order")]
        public Guid OrderId { get; set; }

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
        public Product Product { get; set; }

        public Order Order { get; set; }
    }
}
