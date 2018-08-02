using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hachathon2
{
  public  class campaignDatabaseMethods
    {
        readonly SQLiteAsyncConnection Campaigndatabase;
        public campaignDatabaseMethods(string dbPath)
        {
            Campaigndatabase = new SQLiteAsyncConnection(dbPath);
            Campaigndatabase.CreateTableAsync<campaignDatabase>().Wait();

        }
        public Task<List<campaignDatabase>> GetcampaignAsync()
        {
            return Campaigndatabase.Table<campaignDatabase>().ToListAsync();
        }
        public Task<campaignDatabase> GetcampaignAsync(int id)
        {
            return Campaigndatabase.Table<campaignDatabase>().Where(i => i.CampaignID == id).FirstOrDefaultAsync();
        }
        public Task<int> SavecampaignAsync(campaignDatabase campaign)
        {
            if (campaign.CampaignID != 0)
            {
                return Campaigndatabase.UpdateAsync(campaign);

            }
            else
            {
                return Campaigndatabase.InsertAsync(campaign);

            }

        }

        public Task<int> DeletecampaignAsync(campaignDatabase campaign)
        {
            return Campaigndatabase.DeleteAsync(campaign);
        }

       /* public Task<List<GeneralData>> waitList()
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [OrderStatusNo]=1");

        }

        public Task<List<GeneralData>> processingList()
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [OrderStatusNo]=2");

        }

        public Task<List<GeneralData>> uploadList()
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [OrderStatusNo]=3");

        }

        public Task<List<GeneralData>> finishList()
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [OrderStatusNo]=4");

        }

        public Task<List<GeneralData>> TechMemWaitList(int building)
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [BuildingNo]=? AND [OrderStatusNo]=1", building);
        }

        public Task<List<GeneralData>> TechMemProcessingList(int building)
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [BuildingNo]=? AND [OrderStatusNo]=2", building);
        }
        public Task<List<GeneralData>> TechMemUploadList(int building)
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [BuildingNo]=? AND [OrderStatusNo]=3", building);
        }
        public Task<List<GeneralData>> TechMemFinishList(int building)
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [BuildingNo]=? AND [OrderStatusNo]=4", building);
        }
        public Task<List<GeneralData>> FacultyMemWaitList(string ID)
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [FacultyMemID]=? AND [OrderStatusNo]=1", ID);
        }

        public Task<List<GeneralData>> FacultyMemProcessingList(string ID)
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [FacultyMemID]=? AND [OrderStatusNo]=2", ID);
        }
        public Task<List<GeneralData>> FacultyMemUploadList(string ID)
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [FacultyMemID]=? AND [OrderStatusNo]=3", ID);
        }
        public Task<List<GeneralData>> FacultyMemFinishList(string ID)
        {
            return database.QueryAsync<GeneralData>("SELECT * FROM [GeneralData] WHERE [FacultyMemID]=? AND [OrderStatusNo]=4", ID);
        }*/
    }
}
