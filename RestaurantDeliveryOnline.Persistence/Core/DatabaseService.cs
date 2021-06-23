using Microsoft.EntityFrameworkCore;
using System;
using RestaurantDeliveryOnline.Application.Interfaces;
using RestaurantDeliveryOnline.Domain;
using RestaurantDeliveryOnline.Persistance.Core;

namespace RestaurantDeliveryOnline.Persistance
{
    public class DatabaseService : DbContext, IDatabaseService
    {
        private string connectionString;
        private IServiceProvider provider;
        public DatabaseService(  IServiceProvider provider, IDatabaseServiceOptions options)
        {
            this.provider = provider;
            this.connectionString = options.ConnectionString;
        }

        internal DbSet<City> Cities { set; get; }
        internal DbSet<Restaurant> Restaurants { set; get; }
        internal DbSet<Product> Products { set; get; }
        internal DbSet<Order> Orders { set; get; }
        internal DbSet<User> Users { set; get; }
        internal DbSet<OrderItem> OrderItems { set; get; }

        IRepository<City> IDatabaseService.Cities
        {
            get
            {
                return new Repository<City>(provider);
            }

        }

        IRepository<Product> IDatabaseService.Products
        {
            get
            {
                return new Repository<Product>(provider);
            }

        }

        IRepository<Order> IDatabaseService.Orders
        {
            get
            {
                return new Repository<Order>(provider);
            }

        }
        IRepository<OrderItem> IDatabaseService.OrderItems
        {
            get
            {
                return new Repository<OrderItem>(provider);
            }

        }

        IRepository<User> IDatabaseService.Users
        {
            get
            {
                return new Repository<User>(provider);
            }

        }


        IRepository<Restaurant> IDatabaseService.Restaurants
        {
            get
            {
                return new Repository<Restaurant>(provider);
            }

        }
        public DatabaseService(IDataBaseServiceOptions options) : base()
        {
            this.connectionString = options.ConnectionString;
            provider = options.Provider;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        void IDatabaseService.SaveChanges()
        {
            this.SaveChanges();
        }
    }
}
