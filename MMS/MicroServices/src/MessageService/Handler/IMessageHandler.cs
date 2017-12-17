using MMS.MicroService.MessageService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMS.MicroService.MessageService.Handler
{
    public interface IMessageHandler
    {
        MailBox GetMailBoxByUserAndSynctime(string username, DateTime synctime);
    }
}
