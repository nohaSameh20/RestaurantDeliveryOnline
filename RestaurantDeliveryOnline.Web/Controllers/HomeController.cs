using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantDeliveryOnline.Application.Cities;
using RestaurantDeliveryOnline.Application.Restaurants;
using RestaurantDeliveryOnline.Application.Users;
using RestaurantDeliveryOnline.Web.Models;

namespace RestaurantDeliveryOnline.Web.Controllers
{
    public class HomeController : Controller
    {
        ILoadCitesQuery loadCitesQuery;
        IGetAllRestaurantsQuery getAllRestaurantsQuery;
        IRestaurantCountQuery restaurantCountQuery;
        IUserCountQuery userCountQuery;
        public HomeController(ILoadCitesQuery loadCitesQuery, IGetAllRestaurantsQuery getAllRestaurantsQuery, IRestaurantCountQuery restaurantCountQuery, IUserCountQuery userCountQuery)
        {
            this.loadCitesQuery = loadCitesQuery;
            this.getAllRestaurantsQuery = getAllRestaurantsQuery;
            this.restaurantCountQuery = restaurantCountQuery;
            this.userCountQuery = userCountQuery;

        }
        public IActionResult Index()
        {
            ViewBag.RestaurantCount = restaurantCountQuery.Execute();
            ViewBag.UserCount = userCountQuery.Execute();
            ViewBag.Cities = loadCitesQuery.Execute();
            return View();
        }

        [HttpPost]
        public IActionResult Index(RestaurantFilter filter)
        {

            var res= getAllRestaurantsQuery.Execute(filter);
            ViewBag.Restaurants = res;
            ViewBag.Cities = loadCitesQuery.Execute();
            return View();
        }


    }
}
