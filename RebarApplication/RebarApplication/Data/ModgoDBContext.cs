using MongoDB.Driver;
using RebarApplication.Models;
using System.Security.Principal;

    namespace RebarApplication.Data
    {
        public class MongoDBContext
        {
            private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Order> _orders;

        public MongoDBContext(string connectionString, string databaseName)
            {
                var client = new MongoClient(connectionString);
                _database = client.GetDatabase(databaseName);
                _orders = _database.GetCollection<Order>("Orders");
                //_menu = _database.GetCollection<ShakeMenu>("Menu");
                //_account = _database.GetCollection<AccountToday>("Account");
        }

        //public void AddShakeMenu(ShakeMenu shakeMenu)
        //{
        //    _menu.InsertOne(shakeMenu);
        //}

        //public IMongoCollection<Product> Products => _database.GetCollection<Product>("Products");
    }
    }
