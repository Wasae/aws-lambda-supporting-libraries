using apollo_Business_Entities.Models;
using apollo_EFContext;
using apollo_Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo_Services.Services
{
    public class UserService : IUserRepository
    {
        private EFContext _context = new EFContext();
        public async Task Delete(int id)
        {
            var d = (from u in _context.mst_user
                     where u.user_id == id
                     select u).SingleOrDefault();
            if (d != null) {
                _context.Remove(d);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<mst_user>> GetAll(int pageindex, int recordcount)
        {
            return (from u in _context.mst_user
                    select u).ToList();
        }

        public async Task<mst_user> GetById(int id)
        {
            return (from u in _context.mst_user
                     where u.user_id == id
                     select u).SingleOrDefault();
        }

        public async Task Save(mst_user o)
        {
            _context.Add(o);
            await _context.SaveChangesAsync();
        }

        public async Task Sometask()
        {
            throw new NotImplementedException();
        }

        public async Task Update(mst_user o)
        {
            _context.Update(o);
            await _context.SaveChangesAsync();
        }
    }
}
