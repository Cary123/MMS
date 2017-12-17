using System;
using System.Collections.Generic;
using System.Text;
using MMS.Platform;
     

namespace MMS.Platform.MongoDB
{
    public class MongoDBOAMAdapter : IOAMAdapter
    {
        public void StarUpOAM(MongoDBConfiguration cfg)
        {
            if (cfg != null)
            {
                MongoDBManager.SetMongoDBConfig(cfg);
            }
        }
    }
}
