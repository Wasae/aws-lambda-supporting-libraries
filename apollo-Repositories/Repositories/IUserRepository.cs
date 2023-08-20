using apollo_Business_Entities.Models;
using apollo_Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo_Repositories.Repositories
{
    public interface IUserRepository : IRepository<mst_user>
    {
        Task Sometask();
    }
}
