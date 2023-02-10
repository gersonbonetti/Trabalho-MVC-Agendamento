using MVC_Agendamento_Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Infra_Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
