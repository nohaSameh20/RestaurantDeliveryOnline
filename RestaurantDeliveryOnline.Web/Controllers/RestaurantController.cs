using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantDeliveryOnline.Application;
using RestaurantDeliveryOnline.Application.Restaurants;
using RestaurantDeliveryOnline.Application.Users;

namespace RestaurantDeliveryOnline.Web.Controllers
{
    public class RestaurantController : Controller
    {
        IGetRestaurantDetailsQuery getRestaurantDetailsQuery;
        IAddUserCommand addUserCommand;
       

        public RestaurantController(IGetRestaurantDetailsQuery getRestaurantDetailsQuery, IAddUserCommand addUserCommand)
        {
            this.getRestaurantDetailsQuery = getRestaurantDetailsQuery;
            this.addUserCommand = addUserCommand;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Details(Guid Id)
        {
            ViewBag.RestaurantDetails = getRestaurantDetailsQuery.Execute(Id);
            return View();
        }

        public IActionResult ReserveNow()
        {
            return View();
        }



        [HttpPost]
        public IActionResult ReserveNow(AddUserModel addUserModel)
        {
            var res = addUserCommand.Execute(addUserModel);
            return RedirectToAction("CartData");
        }


        public IActionResult CartData()
        {
            return View();
        }
    }
}
