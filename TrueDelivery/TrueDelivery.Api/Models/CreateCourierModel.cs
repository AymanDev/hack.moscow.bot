﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrueDelivery.Api.Models
{
    public class CreateCourierModel
    {
        public int? TelegramId { get; set; }

        public int? TelegramChatId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }
    }
}