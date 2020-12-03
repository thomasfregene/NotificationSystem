using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Notification.Api.Controllers
{
    public class NotificationTemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
