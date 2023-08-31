using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TekeApp.Models;


namespace TekeApp.Data
{
    public class SQLiteHelper
    {
        readonly SQLiteAsyncConnection _database;

        public SQLiteHelper (string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Registro>().Wait();
        }

        public Task<List<Registro>> GetRegistrosAsync()
        {
            return _database.Table<Registro>().ToListAsync();
        }

        public Task<int> SaveRegistroAsync(Registro registro)
        {
            if (registro.IdRegistro != 0)
            {
                return _database.UpdateAsync(registro);
            }
            else
            {
                return _database.InsertAsync(registro);
            }
        }

        public Task<int> DeleteRegistroAsync(Registro registro)
        {
            return _database.DeleteAsync(registro);
        }
    }
}
