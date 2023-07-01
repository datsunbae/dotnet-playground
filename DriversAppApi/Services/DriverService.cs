using DriversAppApi.Configurations;
using DriversAppApi.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace DriversAppApi.Services
{
    public class DriverService
    {
        private readonly IMongoCollection<Driver> _driverCollection;
        public DriverService(IOptions<DatabaseSettings> databaseSettings)
        {
            var mongoClient = new MongoClient(databaseSettings.Value.ConectionString);
            var mongoDB = mongoClient.GetDatabase(databaseSettings.Value.DatabaseName);
            _driverCollection = mongoDB.GetCollection<Driver>(databaseSettings.Value.CollectionName);
        }

        public async Task<List<Driver>> GetDriversAsync() => await _driverCollection.Find(_ => true).ToListAsync();
        public async Task<Driver> GetDriverAsync(string id) => await _driverCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        public async Task CreateDriverAsync(Driver driver) => await _driverCollection.InsertOneAsync(driver);
        public async Task UpdateDriverAsync(Driver driver) => await _driverCollection.ReplaceOneAsync(x => x.Id == driver.Id, driver);
        public async Task DeleteDriverAsync(string id) => await _driverCollection.DeleteOneAsync(x => x.Id == id);
    }
}