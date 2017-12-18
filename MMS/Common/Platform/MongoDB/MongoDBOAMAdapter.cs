using System;
using System.Collections.Generic;
using System.Text;
using MMS.Platform;
     

namespace MMS.Platform.MongoDB
{
    public class MongoDBOAMAdapter : IOAMAdapter
    {
        public void StarUpOAM(Object obj)
        {
            if (obj != null)
            {
                MongoDBConfiguration cfg = obj as MongoDBConfiguration;
                if (cfg != null)
                {
                    MongoDBManager.SetMongoDBConfig(cfg);
                }
            }
        }
    }
}
