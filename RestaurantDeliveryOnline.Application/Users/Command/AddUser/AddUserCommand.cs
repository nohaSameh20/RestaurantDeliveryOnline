using RestaurantDeliveryOnline.Application.Interfaces;
using RestaurantDeliveryOnline.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Users
{
    public class AddUserCommand : IAddUserCommand
    {
        IDatabaseService databaseService;
        public AddUserCommand(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public Guid Execute(AddUserModel model)
        {
            bool userExist = databaseService.Users.Any(obj => obj.Email.ToUpper() == model.Email.Trim().ToUpper());

            if (userExist)
                throw new Exception("ContactDuplicated");

            User user = new User()
            {
                Id = Guid.NewGuid(),
                Address = model.Address,
                Email = model.Email,
                Name = model.Name,
                Phone=model.Phone,
                CreatedAt=DateTime.Now,
            };
            databaseService.Users.Add(user);
            databaseService.Users.SaveChanges();
            return user.Id;
        }
    }
}
