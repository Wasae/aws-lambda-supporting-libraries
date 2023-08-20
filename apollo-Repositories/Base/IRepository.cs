using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo_Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll(int pageindex, int recordcount);
        Task Save(T o);
        Task Delete(int id);
        Task Update(T o);
    }
}
