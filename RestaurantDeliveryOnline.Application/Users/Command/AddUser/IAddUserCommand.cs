using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Users
{
    public interface IAddUserCommand
    {
        Guid Execute(AddUserModel model);
    }
}
