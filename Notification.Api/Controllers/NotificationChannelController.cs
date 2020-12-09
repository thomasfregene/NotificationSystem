using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notification.ViewModel.ViewModels;

namespace Notification.Api.Controllers
{
    public class NotificationChannelController : Controller
    {
        public IActionResult Index()
        {
            var notificationChannel = new List<NotificationChannelVM>()
            {
                new NotificationChannelVM{Id=1, Name="Tim", Description="text message"}
            };
            return View(notificationChannel);
        }

        public IActionResult GetById(int id)
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Post(NotificationChannelVM notificationChannelVM)
        {
            return View("Index");
        }
    }
}
