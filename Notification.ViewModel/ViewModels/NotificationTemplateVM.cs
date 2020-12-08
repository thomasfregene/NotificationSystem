using Notification.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notification.ViewModel.ViewModels
{
    public class NotificationTemplateVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NotificationTypeId { get; set; }
        public NotificationType NotificationType { get; set; }
        public int NotificationChannelId { get; set; }
        public NotificationChannel NotificationChannel { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
