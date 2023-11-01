using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class Menu
    {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "DatabaseName";
            string collectionName = "RebarMenu";
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            var collection = database.GetCollection<BsonDocument>(collectionName);

            var shake = new BsonDocument
        {
            { "Name", "Strawberry Shake" },
            { "Description", "Delicious strawberry flavored shake" },
            { "PriceL", 5.99 },
            { "PriceM", 4.99 },
            { "PriceS", 3.99 },
            { "ShakeId", "SHK001" }
        };

            await collection.InsertOneAsync(shake);

            Console.WriteLine("Shake added to the menu successfully.");
        }
    }

