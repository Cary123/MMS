using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace Platform.Redis
{
    public class RedisManager
    {
        private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() => {
            return ConnectionMultiplexer.Connect("localhost,abortConnect=false");
        });

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }
        public static IDatabase GetDatabase()
        {
            return Connection.GetDatabase();
        }
             
    }
}
