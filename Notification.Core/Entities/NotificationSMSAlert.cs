﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Notification.Core.Entities
{
    public class NotificationSMSAlert
    {
        public long Id { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string ReceiverName { get; set; }
        //public enum UserType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateProcessed { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string CreatedBy { get; set; }
        public int Sendtries { get; set; }
    }
}
