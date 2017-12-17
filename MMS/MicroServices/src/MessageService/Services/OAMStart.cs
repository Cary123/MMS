using MMS.Platform;
using MMS.Platform.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMS.MicroService.MessageService.Services
{
    public class OAMStart
    {
        public static void StartUpMongoDBOAM(MongoDBConfiguration cfg)
        {
            IOAMAdapter mongoDBAdapter = new MongoDBOAMAdapter();
            mongoDBAdapter.StarUpOAM(cfg);
        }

        public static void StartUpRedisDBOAM(MongoDBConfiguration cfg)
        {
            IOAMAdapter mongoDBAdapter = new MongoDBOAMAdapter();
            mongoDBAdapter.StarUpOAM(cfg);
        }
    }
}
