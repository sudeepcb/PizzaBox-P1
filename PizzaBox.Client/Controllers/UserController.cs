using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.ViewModel;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
    public class UserController : Controller
    {
        private PizzaDBContext _db = new PizzaDBContext();

        public IActionResult Read()
        {
          return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
          UserAddressVM vModels = new UserAddressVM();
          vModels.allAddress = new List<Address>();
          vModels.allAddress = _db.Addresses.ToList();
          vModels.allId = new List<int>();
          foreach (var item in _db.Addresses.ToList())
          {
              vModels.allId.Add(item.addressId);
          }
          return View(vModels);
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
          if(ModelState.IsValid)
          {
            var isUserAlreadyRegistered = _db.Users.Any(x => x.userName == user.userName);
            if(isUserAlreadyRegistered)
            {
              ModelState.AddModelError("userName", "Username already exists try another");
              return RedirectToAction("Read");
            }
            _db.Users.Add(user);
            _db.SaveChanges();
            return RedirectToAction("Read");
          }
          return View();
        }
    }
}