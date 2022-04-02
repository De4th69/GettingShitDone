using SQLite;
using System.Reflection;

namespace GettingShitDone.Database
{
    public class SQLiteRepository
    {
        public readonly SQLiteConnection DataBase;

        public SQLiteRepository()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "gettingshitdone.db");
            DataBase = new SQLiteConnection(dbPath);
        }

        public async Task InitializeDb()
        {
            await Task.Run(() =>
            {
                var assembly = Assembly.GetExecutingAssembly();
                using (var stream = assembly.GetManifestResourceStream("GettingShitDone.Database.DbDefinition.json"))
                {
                    stream.Position = 0;
                    object dbDefinition = System.Text.Json.JsonSerializer.Deserialize<object>(stream);
                    
                }
            });
        }

        public virtual IEnumerable<T> GetAll<T>(string tableName)
        {
            return this.DataBase.CreateCommand($"SELECT * FROM {tableName} WHERE DeleteDate Is Null").ExecuteDeferredQuery<T>();
        }

        public virtual T GetById<T>(Guid id, string tableName)
        {
            IEnumerable<T> result = null;
            if(!string.IsNullOrEmpty(tableName) && id != Guid.Empty)
            {
                result = this.DataBase.CreateCommand($"SELECT * FROM {tableName} WHERE Id = {id} AND DeleteDate Is Null").ExecuteDeferredQuery<T>();
                if(result.Count() == 1)
                {
                    return (T)result;
                }
            }

            return default(T);
        }

        public virtual int Save<T>(T entity)
        {
            return this.DataBase.Insert(entity);
        }
    }
}
