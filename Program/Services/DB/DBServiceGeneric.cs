using CTTSite.EFDbContext;
using Microsoft.EntityFrameworkCore;

namespace CTTSite.Services.DB
{
    public class DBServiceGeneric<T> : Interface.IService<T> where T : class
    {

        public async Task<IEnumerable<T>> GetObjectsAsync()
        {
            using (var context = new ItemDbContext())
            {
                return await context.Set<T>().AsNoTracking().ToListAsync();
            }
        }

        public async Task AddObjectAsync(T obj)
        {
            using (var context = new ItemDbContext())
            {
                context.Set<T>().Add(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteObjectAsync(T obj)
        {
            using (var context = new ItemDbContext())
            {
                context.Set<T>().Remove(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateObjectAsync(T obj)
        {
            using (var context = new ItemDbContext())
            {
                context.Set<T>().Update(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task<T> GetObjectByIdAsync(int id)
        {
            using (var context = new ItemDbContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }

        public async Task SaveObjectsAsync(List<T> objs)
        {
            using (var context = new ItemDbContext())
            {
                foreach (T obj in objs)
                {
                    context.Set<T>().Update(obj);
                }
                await context.SaveChangesAsync();
            }
        }
    }
}
