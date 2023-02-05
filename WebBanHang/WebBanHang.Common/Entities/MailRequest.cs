﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gather.ApplicationCore.Entities
{
    public class MailRequest
    {
        public string FromEmail { get; set; }
        public string FromDisplayName { get; set; }
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public bool IsBodyHtml { get; set; } = true;
    }
}
