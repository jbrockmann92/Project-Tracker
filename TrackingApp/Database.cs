using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using SQLite;
using TrackingApp.Models;
using UIKit;

namespace TrackingApp
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Project>().Wait();
        }

        public Task<List<Project>> GetPeopleAsync()
        {
            return _database.Table<Project>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Project project)
        {
            return _database.InsertAsync(project);
        }
    }
}