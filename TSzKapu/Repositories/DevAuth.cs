using Microsoft.EntityFrameworkCore;
using TSzKapu.Data;
using TSzKapu.Interfaces;

namespace TSzKapu.Repositories
{
    public class DevAuth : IDeviceAuth
    {
        private readonly ApplicationDbContext _context;

        public DevAuth(ApplicationDbContext dbContext)
        {
                _context = dbContext;
        }
        public async Task<User?> GetDevice(string deviceId)
        {
            return await _context.User.SingleOrDefaultAsync(x=>x.Devicename == deviceId);
        }
    }
}
