using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hachathon2
{
  public  class PilgrimDatabaseMethods
    {
        readonly SQLiteAsyncConnection Pilgrimdatabase;
        public PilgrimDatabaseMethods(string dbPath)
        {
            Pilgrimdatabase = new SQLiteAsyncConnection(dbPath);
            Pilgrimdatabase.CreateTableAsync<PilgrimDatabase>().Wait();

        }
        public Task<List<PilgrimDatabase>> GetPilgrimAsync()
        {
            return Pilgrimdatabase.Table<PilgrimDatabase>().ToListAsync();
        }
        public Task<PilgrimDatabase> GetPilgrimAsync(int id)
        {
            return Pilgrimdatabase.Table<PilgrimDatabase>().Where(i => i.CampaignID == id).FirstOrDefaultAsync();
        }
        public Task<int> SavePilgrimAsync(PilgrimDatabase Pilgrim)
        {
            if (Pilgrim.CampaignID != 0)
            {
                return Pilgrimdatabase.UpdateAsync(Pilgrim);

            }
            else
            {
                return Pilgrimdatabase.InsertAsync(Pilgrim);

            }

        }

        public Task<int> DeletePilgrimAsync(PilgrimDatabase Pilgrim)
        {
            return Pilgrimdatabase.DeleteAsync(Pilgrim);
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
