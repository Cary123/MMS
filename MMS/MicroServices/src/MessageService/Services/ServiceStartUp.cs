using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MMS.Platform.Redis;
using MMS.Platform.MongoDB;
using MMS.Platform;


namespace MMS.MicroService.MessageService.Services
{
    public class ServiceStartUp
    {
        public static void StartUpRedis(Object obj)
        {
            IOAMAdapter adpater = new RedisOAMAdapter();
            adpater.StarUpOAM(obj);
        }

        public static void StartUpMongoDB(Object obj)
        {
            IOAMAdapter adpater = new MongoDBOAMAdapter();
            adpater.StarUpOAM(obj);
        }
    }
}
