using GettingShitDone.Database;

namespace GettingShitDone.Interfaces
{
    public interface ISQLiteRepository<T>
    {
        public List<T> Save<TModel>(T model);

        public List<T> Update<TModel>(T model);

        public List<T> GetAll();

        public T GetById(Guid? id);

        public List<T> Delete(Guid? id);
    }
}
