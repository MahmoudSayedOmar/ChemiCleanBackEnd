using CROSSWORKERS.CHEMICLEAN.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CROSSWORKERS.CHEMICLEAN.Data
{
    public class ChemiCleanRepository<T> : IRepository<T> where T : class
    {
        private readonly ChemiCleanContext _uof;
        public ChemiCleanRepository(ChemiCleanContext uof)
        {
            _uof = uof;
        }
        public IUnitOfWork UOF => _uof;

        public async Task<T> Add(T entity)
        {
            _uof.Set<T>().Add(entity);
            await _uof.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _uof.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _uof.Set<T>().Remove(entity);
            await _uof.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Get(int id)
        {
            return await _uof.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _uof.Set<T>().ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            _uof.Entry(entity).State = EntityState.Modified;
            await _uof.SaveChangesAsync();
            return entity;
        }

    }
}
