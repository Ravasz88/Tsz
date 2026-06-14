using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TSzKapu.Data;
using TSzKapu.Interfaces;

namespace TSzKapu.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task CreateUser([FromBody] User newuser)
        {
            dbContext.User.Add(newuser);
            dbContext.SaveChanges();
        }
       

        public async Task<IEnumerable<User>> GetAll()
        {
            var elem =  dbContext.User.Where(x=>x.Id != 0).ToList();
            return elem;
        }

        public Task<User> Get(string email)
        {
            var user = dbContext.User.FirstOrDefaultAsync(x=>x.Email == email);
            return user;
        }

        public async Task NewDevice(User newUser, User user)
        {
            
        }
    }
}
