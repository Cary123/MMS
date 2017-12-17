using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMS.MicroService.MessageService.Models
{
    public class MailBoxConfiguration
    {
        public long MaxSize { get; set; }
        public SizeType MaxSizeType { get; set; }
        public long MaxSyncNum { get; set; }
    }
}
