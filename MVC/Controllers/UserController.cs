﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetUserCard()
        {
            var user = _userService.GetUser(1).Data;
            return PartialView(user);
        }
    }
}
