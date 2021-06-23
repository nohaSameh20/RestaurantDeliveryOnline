using RestaurantDeliveryOnline.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDeliveryOnline.Application.Interfaces
{
    public interface IDatabaseService
    {
        IRepository<City> Cities { get; }
        IRepository<User> Users { get; }
        IRepository<Restaurant> Restaurants { get; }
        IRepository<Product> Products { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderItem> OrderItems { get; }

        //bool ExecuteTransaction(Action transactionBody);
        void SaveChanges();
    }
}
