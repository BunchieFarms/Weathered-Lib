using MongoDB.Driver;
using Weathered_Lib.Models;

namespace Weathered_Lib.Mongo
{
    public static class MongoBase
    {
        public static IMongoCollection<NoaaArchiveUpdate> NoaaArchUpdateColl;
        public static IMongoCollection<PastWeekStationData> PastStationDataColl;

        public static void SetupMongoBase(string weatheredDbString)
        {
            IMongoDatabase WeatheredDB = new MongoClient(weatheredDbString)
                            .GetDatabase(Constants.WeatheredDB);

            NoaaArchUpdateColl = WeatheredDB.GetCollection<NoaaArchiveUpdate>(Constants.NoaaArchiveUpdate);

            PastStationDataColl = WeatheredDB.GetCollection<PastWeekStationData>(Constants.PastWeekStationData);
        }
    }
}
