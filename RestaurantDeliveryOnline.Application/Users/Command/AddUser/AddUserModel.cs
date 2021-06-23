using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application
{
    public class AddUserModel
    {
        public string Name { get; set; }

        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
