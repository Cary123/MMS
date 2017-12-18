using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MMS.Platform.Redis;
using StackExchange.Redis;

namespace MMS.MicroService.MessageService.Services
{
    public class DeliverQueueListener
    {
        public void Listen(object state)
        {
            IDatabase db = RedisManager.GetDatabase();
        }
    }
}
