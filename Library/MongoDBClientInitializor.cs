using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class MongoDBClientInitializor
    {
        public MongoClient GetMongoClient()
        {
            return new MongoClient("YOUR_CONNECTION_STRING");
        }
    }
}
