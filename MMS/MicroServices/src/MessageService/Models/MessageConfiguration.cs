using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMS.Micro.MessageService.Models
{
    public class MessageConfiguration
    {
        public long MessageMaxSize { get; set; }
        public SizeType MessageMaxSizeType { get; set; }
        public long AttachmentMaxSize { get; set; }
        public SizeType AttachmentMaxSizeType { get; set; }
        public string SystemSender { get; set; }
        public string FailureDeliverSubject { get; set; }
        public string FailureDeliverContent { get; set; }
    }
}
