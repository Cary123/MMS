using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMS.Micro.MessageService.Models
{
    public class SMTPConfiguration
    {
        public bool EnableInboundSMTP { get; set; }
        public bool EnableOutboundSMTP { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
