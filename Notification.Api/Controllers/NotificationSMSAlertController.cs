using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Notification.Api.Controllers
{
    public class NotificationSMSAlertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetById(int id)
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
