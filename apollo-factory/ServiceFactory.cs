
using apollo_Repositories.Repositories;
using apollo_Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apollo_factory
{
    public static class ServiceFactory
    {
        public static Object getInstance(string s)
        {
            if (s.Equals(typeof(IUserRepository)))
            {
                return new UserService();
            }
            return null;
        }
    }
}
