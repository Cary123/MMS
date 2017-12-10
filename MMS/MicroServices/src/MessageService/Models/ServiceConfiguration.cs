using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMS.Micro.MessageService.Models
{
    public class ServiceConfiguration
    {
        public MessageConfiguration MessageCfg { get; set; }
        public MailBoxConfiguration MailBoxCfg { get; set; }
        public SMTPConfiguration SMTPCfg { get; set; }
        public long TimeOut { get; set; }
    }
}
