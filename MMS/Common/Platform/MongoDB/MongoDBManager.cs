using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Xml.Linq;
using System.Linq;

namespace MMS.Platform.MongoDB
{
    public class MongoDBManager 
    {
        private static MongoDBConfiguration cfg;

        private static string connectionString;

        private static string databaseName;

        private static string ConnectionStringTemplate = "mongodb://<username>:<password>@<servername>";

        public static void SetMongoDBConfig(MongoDBConfiguration configuration)
        {
            if (cfg != null)
            {
                cfg = configuration;
                UpdateConnectionString();
            }
        }

        private static void UpdateConnectionString()
        {
            string temporaryString = ConnectionStringTemplate;
            if (cfg != null)
            {
                if (!string.IsNullOrWhiteSpace(cfg.ServerIp))
                    temporaryString = temporaryString.Replace("<servername>", cfg.ServerIp);

                if (!string.IsNullOrWhiteSpace(cfg.UserName))
                    temporaryString = temporaryString.Replace("<username>", cfg.UserName);

                if (!string.IsNullOrWhiteSpace(cfg.Password))
                    temporaryString = temporaryString.Replace("<password>", cfg.Password);

                if (cfg.SlaveOk || cfg.Ssl)
                {
                    temporaryString += "/?";

                    if (cfg.SlaveOk)
                    {
                        temporaryString += "connect=direct;slaveok=true";

                        if (cfg.Ssl)
                            temporaryString += ";";
                    }

                    if (cfg.Ssl)
                    {
                        temporaryString += "ssl=true;sslverifycertificate=false";
                    }
                }

                if (!string.IsNullOrWhiteSpace(cfg.DatabaseName))
                {
                    databaseName = cfg.DatabaseName;
                }
            }
            

            connectionString = temporaryString;
        }

        /// <summary>
        /// Creates an instance of the connection type.
        /// </summary>
        /// <param name="txn">The handle to a transaction object. (optional)</param>
        /// <returns></returns>
        public IMongoDatabase GetMongoDatabase()
        {
            IMongoDatabase database = null;
            if (string.IsNullOrWhiteSpace(connectionString))
                UpdateConnectionString();

            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                IMongoClient client = new MongoClient(connectionString);

                if (string.IsNullOrWhiteSpace(databaseName))
                    throw new Exception("No database specified");

                database = client.GetDatabase(databaseName);
            }
            else
            {
                throw new Exception("Can not connect to MongoDB with empty connection string");
            }

            return database;
        }

    }
}
