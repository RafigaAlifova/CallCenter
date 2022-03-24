using System.Data.Entity;
using Core.Entities.Abstract;

namespace Core.DataAccess.Extention
{
    public static class DbSetExtentions
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class, IEntity, new()
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}
