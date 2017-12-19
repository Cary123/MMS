using System;
using System.Collections.Generic;
using System.Text;

namespace MMS.Platform.Redis
{

    public class RedisConfiguration
    {
        /// <summary>
        /// Server ip.
        /// </summary>
        public string ServerIp
        {
            get;
            set;
        }

        /// <summary>
        /// Port.
        /// </summary>
        public int Port
        {
            get;
            set;
        }

        /// <summary>
        /// The database user
        /// </summary>
        public string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// The password for the database user
        /// </summary>
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// If true, this will force the connection to use SSL
        /// The database must be running in SSL mode in order for this to work
        /// </summary>
        public bool Ssl
        {
            get;
            set;
        }

    }
}
