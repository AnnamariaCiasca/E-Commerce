using E_Commerce.Core.Interfaces;
using E_Commerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.EF.Repositories
{
    public class RepositoryUsersEF : IRepositoryUser
    {
        private readonly AmazonContext ctx;

        public RepositoryUsersEF(AmazonContext context)
        {
            this.ctx = context;
        }
        public bool Add(User item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Fetch()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetByUsername(string username)
        {
            using (var ctx = new AmazonContext())
            {
                if (string.IsNullOrEmpty(username))
                {
                    return null;
                }
                return ctx.Users.FirstOrDefault(u => u.Username == username);
            }
        }

        public bool Update(User updatedItem)
        {
            throw new NotImplementedException();
        }
    }
}
