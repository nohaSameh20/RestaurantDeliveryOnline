using CharityProject.Domain.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDeliveryOnline.Domain
{
    [Table(nameof(User))]
    public class User : Entity<Guid>
    {
     
        public string Name { get; set; }

        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public List<Order> Orders { get; set; }
    }
}
