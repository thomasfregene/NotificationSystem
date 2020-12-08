﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.ViewModel.ViewModels
{
    class NotificationTypeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}