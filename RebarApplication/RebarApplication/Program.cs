using System;
using MongoDB.Bson;
using MongoDB.Driver;

class Program
{
    static async System.Threading.Tasks.Task Main(string[] args)
    {
        string connectionString = "mongodb://localhost:27017";
        string databaseName = "Reabar";
        string collectionName = "RebarMenue";

        MongoClient client = new MongoClient(connectionString);
        IMongoDatabase database = client.GetDatabase(databaseName);
        IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(collectionName);

        // Inserting data for income
        BsonDocument incomeDocument = new BsonDocument
        {
            { "Type", "Income" },
            { "Amount", 500 },
            { "Date", DateTime.Now }
        };
        
        await collection.InsertOneAsync(incomeDocument);

        // Inserting data for expenditure
        BsonDocument expenditureDocument = new BsonDocument
        {
            { "Type", "Expenditure" },
            { "Amount", 200 },
            { "Date", DateTime.Now }
        };

        await collection.InsertOneAsync(expenditureDocument);

        // Querying the collection for all transactions
        FilterDefinition<BsonDocument> filter = new BsonDocument();
        var transactions = await collection.Find(filter).ToListAsync();

        // Displaying the transactions
        foreach (var transaction in transactions)
        {
            Console.WriteLine(transaction.ToJson());
        }
    }
}
