using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MMS.MicroService.MessageService.Models;
using MMS.MicroService.MessageService.DAL;

namespace MMS.MicroService.MessageService.Handler
{
    public class MessageHandler : IMessageHandler
    {
        private MessageDAL messageDAL;

        private ServiceConfigDAL serviceConfigDAL;

        private static readonly ServiceConfiguration ConfigCache = new ServiceConfiguration();

        private const long  DefaultMaxSyncNum = 500;

        public MessageHandler()
        {
            messageDAL = new MessageDAL();
            serviceConfigDAL = new ServiceConfigDAL();
        }

        public MessageHandler(MessageDAL messageDAL, ServiceConfigDAL serviceConfigDAL)
        {
            this.messageDAL = messageDAL;
            this.serviceConfigDAL = serviceConfigDAL;
        }


        public MailBox GetMailBoxByUserAndSynctime(string username, DateTime synctime)
        {
            MailBox mailBox = null;
            long maxSyncNum = DefaultMaxSyncNum;
            if (ConfigCache != null && ConfigCache.MailBoxCfg != null)
            {
                MailBoxConfiguration mailBoxConfig = ConfigCache.MailBoxCfg;
                if (mailBoxConfig.MaxSyncNum > 0)
                {
                    maxSyncNum = mailBoxConfig.MaxSyncNum;
                }
            }
            mailBox = messageDAL.GetMailBoxByUserAndSyncTime(username, synctime, maxSyncNum);
            return mailBox;
            
        }
    }
}
