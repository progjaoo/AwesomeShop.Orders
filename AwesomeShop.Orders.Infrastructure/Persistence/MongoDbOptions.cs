using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShop.Orders.Infrastructure.Persistence
{
    public class MongoDbOptions
    {
        public string Database { get; set; }
        public string ConnectionString { get; set; }
    }
}