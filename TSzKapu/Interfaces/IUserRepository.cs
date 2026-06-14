using TSzKapu.Data;
namespace TSzKapu.Interfaces
{
    public interface IUserRepository
    {
        Task CreateUser(User user);

        Task<IEnumerable<User>> GetAll();
    }
}
