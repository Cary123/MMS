using MMS.Platform.MongoDB;
using System;

namespace MMS.Platform
{
    public interface IOAMAdapter
    {
        void StarUpOAM(MongoDBConfiguration cfg);
    }
}
