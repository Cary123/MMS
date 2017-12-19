using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace MMS.Platform.Redis
{
    public class RedisManager
    {
        private static RedisConfiguration configuration;

        private IDatabase db;

        private static ConnectionMultiplexer connection = null;

        private static Object connLock = new object();

        private static string connectionString = string.Empty;

        public static ConnectionMultiplexer Connection
        {
            get
            {
                if (connection == null)
                {
                    lock (connLock)
                    {
                        if (connection == null)
                        {
                            connection = ConnectionMultiplexer.Connect(connectionString);
                        }
                    }
                }
                return connection;
            }
        }
        public static IDatabase GetDatabase()
        {
            return Connection.GetDatabase();
        }

        public static void SetRedisConfig(RedisConfiguration cfg)
        {
            if (cfg != null)
            {
                configuration = cfg;
                UpdateConnectString(cfg);
            }
        }

        private static void UpdateConnectString(RedisConfiguration cfg)
        {
            if (cfg != null)
            {
                if (!string.IsNullOrWhiteSpace(cfg.ServerIp))
                {
                    connectionString = cfg.ServerIp;
                    if (cfg.Port != 0)
                    {
                        connectionString += ":" + cfg.Port;
                    }
                }
                if (!string.IsNullOrWhiteSpace(cfg.Password))
                {
                    connectionString += ",password=" +  cfg.Password;
                }
                if (cfg.Ssl)
                {
                    connectionString += ",ssl=" + cfg.Ssl;
                }
            }
        }


    }
}
