using MVC_Agendamento_Domain.IRepositories;
using MVC_Agendamento_Infra_Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Repositories {
    public class BaseRepository<T> : IBaseRepository<T> where T : class {
        private readonly SQLServerContext _context;

        public BaseRepository(SQLServerContext context) {
            _context = context;
        }

        public IQueryable<T> FindAll() {
            return _context.Set<T>();
        }

        public async Task<T> FindById(int id) {
            return await _context.Set<T>().FindAsync(id);
        }

        public Task<int> Save(T entity) {
            _context.Set<T>().Add(entity);
            return _context.SaveChangesAsync();
        }

        public Task<int> Update(T entity) {
            _context.Set<T>().Update(entity);
            return _context.SaveChangesAsync();
        }

        public Task<int> Delete(T entity) {
            _context.Set<T>().Remove(entity);
            return _context.SaveChangesAsync();
        }
    }
}
