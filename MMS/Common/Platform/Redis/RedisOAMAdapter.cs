using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Platform.Redis
{
    public class RedisOAMAdapter : IOAMAdapter
    {
        public void StarUpOAM(object obj)
        {
            if (obj != null)
            {
                RedisConfiguration cfg = obj as RedisConfiguration;
                if (cfg != null)
                {
                    RedisManager.SetRedisConfig(cfg);
                }
            }
        }
    }
}
