﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Notification.Api.Controllers
{
    public class NotificationEmailAlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetById(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Post()
        {
            return View();
        }
    }
}
